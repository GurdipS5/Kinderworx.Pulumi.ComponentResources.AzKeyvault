using Nuke.Common;

class Build : NukeBuild
{
    /// <summary>
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    /// </summary>


    #region Secrets

    ///
    [Parameter]
    [Secret]
    readonly string SonarKey;

    [Parameter]
    [Secret]
    readonly string SNYK_TOKEN;

    [Parameter]
    [Secret]
    readonly string DTrackApiKey;

    /// <summary>
    ///  jkhuj
    /// </summary>
    [Parameter]
    [Secret]
    readonly string CodecovSecret;


    /// <summary>
    ///  ll
    /// </summary>
    [Parameter]
    [Secret]
    readonly string GitHubToken;


    /// <summary>
    ///  ProGet server key.
    /// </summary>
    [Parameter]
    [Secret]
    readonly string NuGetApiKey;

    #endregion

    public static int Main () => Execute<Build>(x => x.Compile);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
        });

    Target Restore => _ => _
        .Executes(() =>
        {
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
        });

    Target PushToProGet => _ => _
      .DependsOn(Restore)
      .Executes(() =>
      {
      });

}

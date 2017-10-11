Public NotInheritable Class SplashScreen

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  

        'TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
        '  boîte de dialogue Propriétés du projet (sous le menu "Projet").

        'Mettez en forme les informations de version à l'aide du texte défini dans la gestion de version au moment du design en tant que
        '  chaîne de mise en forme.  Ceci permet une localisation efficace si besoin est.
        '  Les informations de génération et de révision peuvent être incluses en utilisant le code suivant et en remplaçant le 
        '  texte de la gestion de version par "Version {0}.{1:00}.{2}.{3}" ou un équivalent. Consultez
        '  String.Format() dans l'aide pour plus d'informations.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Version.Text = String.Format("Version {0}", My.Application.Info.Version)

        'Informations de copyright
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class

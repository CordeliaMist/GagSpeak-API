namespace Gagspeak.API.Routes;

// no purpose yet but likely will later???
public class MareAuth
{
     public const string Auth = "/auth"; // the authentication path.
     public const string Auth_CreateIdent = "createWithIdent"; // creating a new identity for the user authentication
     public const string Auth_RenewToken = "renewToken"; // renewing the token for the user authentication
     public static Uri AuthFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_CreateIdent);
     public static Uri RenewTokenFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_RenewToken);
}
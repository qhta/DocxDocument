namespace DocumentModel.Utils;
public static class BuiltInPropertiesUtils
{
  public static void CopyTo(this BuiltInProperties source, PackageProperties target)
  {
    target.Title = source.Title;
    target.Creator = source.Creator;
    target.Created = source.Created;
    target.LastModifiedBy = source.LastModifiedBy;
    target.Modified = source.Modified;
    target.LastPrinted = source.LastPrinted;
    target.Category = source.Category;
    target.ContentStatus = source.ContentStatus;
    target.ContentType = source.ContentType;
    target.Description = source.Description;
    target.Identifier = source.Identifier;
    target.Keywords = source.Keywords;
    target.Language = source.Language;
    target.Revision = source.Revision;
    target.Subject = source.Subject;
    target.Version = source.Version;
  }

  public static void CopyTo(this BuiltInProperties source, DXEP.Properties target)
  {

  }
}

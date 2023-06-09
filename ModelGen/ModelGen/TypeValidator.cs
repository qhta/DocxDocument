namespace ModelGen;
public class TypeValidator
{
  public int CheckedTypesCount { get; private set;}
  public int NoDocsTypesCount { get; private set;}
  public int NoSummaryTypesCount { get; private set;}

  public bool ValidateDocumentation(this TypeInfo typeInfo)
  {
    CheckedTypesCount++;
    var metadata = typeInfo.Metadata;
    if (metadata!=null)
    {
      bool ok = true;
      if (metadata.Summary == null)
      {
        NoSummaryTypesCount++;
        ok = false;
      }
      return ok;
    }
    else
    {
      NoDocsTypesCount++;
      return false;
    }
  }
}

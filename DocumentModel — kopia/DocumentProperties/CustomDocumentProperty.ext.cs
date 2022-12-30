namespace DocumentModel.Properties;

public partial class CustomDocumentProperty
{

  public override string ToString()
  {
    var str = $"{Name} = {Value}";
    if (FormatId != null && FormatId.Length > 0)
      str += $", FormatId={FormatId}";
    if (LinkTarget != null && LinkTarget.Length > 0)
      str += $", LinkTarget={LinkTarget}";
    return str;
  }

}
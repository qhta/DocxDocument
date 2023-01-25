namespace DocumentModel.Properties;

public partial class CustomDocumentProperty : DocumentProperty
{
  public CustomDocumentProperty(): base() { }

  public CustomDocumentProperty(DocumentProperty baseProperty)
  { 
    Name = baseProperty.Name;
    Value = baseProperty.Value;
    if (baseProperty is CustomDocumentProperty customDocumentProperty)
    {
      FormatId = customDocumentProperty.FormatId;
      LinkTarget = customDocumentProperty.LinkTarget;
    }
  }

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
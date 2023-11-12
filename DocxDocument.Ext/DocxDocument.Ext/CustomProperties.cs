namespace DocumentModel;

/// <summary>
/// This class represents a set of document properties stored in openXml document package
/// in CustomFilePropertiesPart.
/// </summary>
public partial class CustomProperties: IdentifiedElementCollection<DXCP.Properties, DXCP.CustomDocumentProperty, DM.CustomProperty>
{
  public CustomProperties(): base() { }

  public CustomProperties(DXCP.Properties properties): base(properties) { }

}

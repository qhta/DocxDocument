namespace DocumentModel;

/// <summary>
/// This class represents a set of document properties stored in openXml document package
/// in CustomFilePropertiesPart.
/// </summary>
public partial class CustomProperties: IdentifiedElementCollection<DXCP.Properties, DXCP.CustomDocumentProperty, DM.CustomProperty>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public CustomProperties(): base() { }

  /// <summary>
  /// Constructor with any OpenXmlElement parameter.
  /// </summary>
  /// <param name="openXmlElement"></param>
  public CustomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  /// <summary>
  /// Constructor with OpenXml properties parameter
  /// </summary>
  /// <param name="openXmlProperties"></param>
  public CustomProperties(DXCP.Properties openXmlProperties): base(openXmlProperties) { }

}

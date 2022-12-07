namespace DocumentModel.Drawings;

/// <summary>
/// Connection.
/// </summary>
public class ConnectionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>, Connection
{
  /// <summary>
  /// Point Type
  /// </summary>
  public ConnectionKind? Type
  {
    get => (ConnectionKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}

namespace DocumentModel;

/// <summary>
/// This class represents a set of document properties stored in openXml document package
/// in CustomFilePropertiesPart.
/// </summary>
public partial class CustomProperties
{
  public CustomProperties()
  {
    _CustomFileProperties = new DXCP.Properties();
  }

  public CustomProperties(DXCP.Properties properties)
  {
    _CustomFileProperties = properties;
  }

  #region CustomProperties

  internal DXCP.Properties _CustomFileProperties { get; private set; }

  #endregion

}

namespace DocumentModel.Math;

/// <summary>
/// Defines the OfficeMathArgumentType Class.
/// </summary>
public partial class OfficeMathArgumentTypeImpl: ModelElementImpl, OfficeMathArgumentType
{
  public DocumentFormat.OpenXml.Math.OfficeMathArgumentType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.OfficeMathArgumentType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OfficeMathArgumentTypeImpl(): base() {}
  
  public OfficeMathArgumentTypeImpl(DocumentFormat.OpenXml.Math.OfficeMathArgumentType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Argument Properties.
  /// </summary>
  public virtual DocumentModel.Math.ArgumentProperties? ArgumentProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
        if (item != null)
          return new DocumentModel.Math.ArgumentPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ArgumentPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

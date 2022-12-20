namespace DocumentModel.UI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbarImpl: ModelElementImpl, QuickAccessToolbar
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public QuickAccessToolbarImpl(): base() {}
  
  public QuickAccessToolbarImpl(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SharedQatControls.
  /// </summary>
  public DocumentModel.UI.SharedQatControls? SharedQatControls
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
        if (item != null)
          return new DocumentModel.UI.SharedQatControlsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.SharedQatControlsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  public DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
        if (item != null)
          return new DocumentModel.UI.DocumentSpecificQuickAccessToolbarControlsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.DocumentSpecificQuickAccessToolbarControlsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

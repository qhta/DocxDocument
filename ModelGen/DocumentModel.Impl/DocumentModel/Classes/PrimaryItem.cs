namespace DocumentModel;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
public partial class PrimaryItemImpl: ModelElementImpl, PrimaryItem
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PrimaryItemImpl(): base() {}
  
  public PrimaryItemImpl(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  public DocumentModel.BackstageRegularButton? BackstageRegularButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
        if (item != null)
          return new DocumentModel.BackstageRegularButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstageRegularButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  public DocumentModel.BackstagePrimaryMenu? BackstagePrimaryMenu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
        if (item != null)
          return new DocumentModel.BackstagePrimaryMenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstagePrimaryMenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

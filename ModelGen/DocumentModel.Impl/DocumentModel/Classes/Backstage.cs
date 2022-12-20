namespace DocumentModel;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
public partial class BackstageImpl: ModelElementImpl, Backstage
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Backstage?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageImpl(): base() {}
  
  public BackstageImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnShow
  {
    get => (System.String?)OpenXmlElement?.OnShow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnShow = (System.String?)value;
    }
  }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnHide
  {
    get => (System.String?)OpenXmlElement?.OnHide?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnHide = (System.String?)value;
    }
  }
  
  public DocumentModel.BackstageTab? BackstageTab
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>();
        if (item != null)
          return new DocumentModel.BackstageTabImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstageTabImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.BackstageFastCommandButton? BackstageFastCommandButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>();
        if (item != null)
          return new DocumentModel.BackstageFastCommandButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstageFastCommandButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

namespace DocumentModel;

/// <summary>
/// Defines the SharedControlsQatItems Class.
/// </summary>
public partial class SharedControlsQatItemsImpl: ModelElementImpl, SharedControlsQatItems
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SharedControlsQatItemsImpl(): base() {}
  
  public SharedControlsQatItemsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.ControlCloneQat? ControlCloneQat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>();
        if (item != null)
          return new DocumentModel.ControlCloneQatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ControlCloneQatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ButtonRegular? ButtonRegular
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
        if (item != null)
          return new DocumentModel.ButtonRegularImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ButtonRegularImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Separator? Separator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
        if (item != null)
          return new DocumentModel.SeparatorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.SeparatorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

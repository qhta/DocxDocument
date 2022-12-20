namespace DocumentModel.UI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public partial class DocumentSpecificQuickAccessToolbarControlsImpl: ModelElementImpl, DocumentSpecificQuickAccessToolbarControls
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocumentSpecificQuickAccessToolbarControlsImpl(): base() {}
  
  public DocumentSpecificQuickAccessToolbarControlsImpl(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.UI.QuickAccessToolbarControlClone? QuickAccessToolbarControlClone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
        if (item != null)
          return new DocumentModel.UI.QuickAccessToolbarControlCloneImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.QuickAccessToolbarControlCloneImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.UnsizedButton? UnsizedButton
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
        if (item != null)
          return new DocumentModel.UI.UnsizedButtonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.UnsizedButtonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.UI.VerticalSeparator? VerticalSeparator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
        if (item != null)
          return new DocumentModel.UI.VerticalSeparatorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.VerticalSeparatorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

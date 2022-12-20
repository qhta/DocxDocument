namespace DocumentModel.UI;

/// <summary>
/// Defines CustomUI.
/// </summary>
public partial class CustomUIImpl: ModelElementImpl, CustomUI
{
  public DocumentFormat.OpenXml.Office.CustomUI.CustomUI? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.CustomUI?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomUIImpl(): base() {}
  
  public CustomUIImpl(DocumentFormat.OpenXml.Office.CustomUI.CustomUI openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the CustomUIPart associated with this element, it could either be a QuickAccessToolbarCustomizationsPart or a RibbonExtensibilityPart.
  /// </summary>
  public DocumentModel.Packaging.CustomUIPart? CustomUIPart
  {
    get
    {
      if (OpenXmlElement?.CustomUIPart != null)
        return new DocumentModel.Packaging.CustomUIPartImpl(OpenXmlElement.CustomUIPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.CustomUIPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
  /// <summary>
  /// onLoad
  /// </summary>
  public String? OnLoad
  {
    get => (System.String?)OpenXmlElement?.OnLoad?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnLoad = (System.String?)value;
    }
  }
  
  /// <summary>
  /// loadImage
  /// </summary>
  public String? LoadImage
  {
    get => (System.String?)OpenXmlElement?.LoadImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LoadImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// RepurposedCommands.
  /// </summary>
  public DocumentModel.UI.RepurposedCommands? RepurposedCommands
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
        if (item != null)
          return new DocumentModel.UI.RepurposedCommandsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.RepurposedCommandsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  public DocumentModel.UI.Ribbon? Ribbon
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
        if (item != null)
          return new DocumentModel.UI.RibbonImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.UI.RibbonImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

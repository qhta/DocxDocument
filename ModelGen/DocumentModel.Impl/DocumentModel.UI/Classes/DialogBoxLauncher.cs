namespace DocumentModel.UI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public partial class DialogBoxLauncherImpl: ModelElementImpl, DialogBoxLauncher
{
  public DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DialogBoxLauncherImpl(): base() {}
  
  public DialogBoxLauncherImpl(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// UnsizedButton.
  /// </summary>
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
  
}

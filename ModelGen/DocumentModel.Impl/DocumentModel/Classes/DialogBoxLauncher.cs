namespace DocumentModel;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
public partial class DialogBoxLauncherImpl: ModelElementImpl, DialogBoxLauncher
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DialogBoxLauncherImpl(): base() {}
  
  public DialogBoxLauncherImpl(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ButtonRegular.
  /// </summary>
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
  
}

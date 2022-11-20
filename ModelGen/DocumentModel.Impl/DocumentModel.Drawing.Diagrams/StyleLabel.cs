namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IScene3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IShape3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITextProperties))]
public class StyleLabel: IStyleLabel
{
  /// <summary>
  /// Style Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IScene3D? Scene3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public IShape3D? Shape3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextProperties? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IStyle? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}

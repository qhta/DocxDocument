namespace DocumentModel.Presentation;

/// <summary>
/// Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualShapeProperties))]
public class Shape: IShape
{
  /// <summary>
  /// Use Background Fill
  /// </summary>
  public bool? UseBackgroundFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public DocumentModel.Presentation.INonVisualShapeProperties? NonVisualShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Presentation.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Presentation.IShapeStyle? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Presentation.ITextBody? TextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification
  {
    get;
    set;
  }
  
}

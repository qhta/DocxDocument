namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public class Shape1Impl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.Shape>, Shape1
{
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties5? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle1? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public TextBody2? TextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D2? Transform2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}

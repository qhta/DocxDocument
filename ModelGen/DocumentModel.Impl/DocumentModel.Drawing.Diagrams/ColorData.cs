namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDataModel))]
public class ColorData: IColorData
{
  /// <summary>
  /// Use Default
  /// </summary>
  public bool? UseDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IDataModel? DataModel
  {
    get;
    set;
  }
  
}

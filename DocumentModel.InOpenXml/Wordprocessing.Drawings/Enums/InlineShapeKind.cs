namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Specifies the type of inline shape.
/// </summary>
public enum InlineShapeKind
{
  /// <summary>Picture or image</summary>
  Picture = 3,
  /// <summary>Linked picture</summary>
  LinkedPicture = 4,
  /// <summary>OLE object</summary>
  OLEObject = 7,
  /// <summary>Chart</summary>
  Chart = 12,
  /// <summary>SmartArt graphic</summary>
  SmartArt = 15,
  /// <summary>3D model</summary>
  Model3D = 30
}
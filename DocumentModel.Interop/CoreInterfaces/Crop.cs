using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Crop: InteropObject
{
  public float PictureOffsetX { get; set; }
  public float PictureOffsetY { get; set; }
  public float PictureWidth { get; set; }
  public float PictureHeight { get; set; }
  public float ShapeLeft { get; set; }
  public float ShapeTop { get; set; }
  public float ShapeWidth { get; set; }
  public float ShapeHeight { get; set; }
}

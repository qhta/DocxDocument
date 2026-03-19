using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Crop: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  float PictureOffsetX { get; set; }
  float PictureOffsetY { get; set; }
  float PictureWidth { get; set; }
  float PictureHeight { get; set; }
  float ShapeLeft { get; set; }
  float ShapeTop { get; set; }
  float ShapeWidth { get; set; }
  float ShapeHeight { get; set; }
}
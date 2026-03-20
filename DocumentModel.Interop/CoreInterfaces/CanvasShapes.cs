using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface CanvasShapes: InteropObject, IEnumerable
{
  int Count { get; }
  Shape Item(object Index);
  new IEnumerator GetEnumerator();
  Shape AddCallout(MsoCalloutType Type, float Left, float Top, float Width, float Height);
  Shape AddConnector(MsoConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);
  Shape AddCurve(object SafeArrayOfPoints);
  Shape AddLabel(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  Shape AddLine(float BeginX, float BeginY, float EndX, float EndY);

  Shape AddPicture
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width,
    float Height);

  Shape AddPolyline(object SafeArrayOfPoints);
  Shape AddShape(MsoAutoShapeType Type, float Left, float Top, float Width, float Height);

  Shape AddTextEffect
  (MsoPresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, MsoTriState FontBold,
    MsoTriState FontItalic, float Left, float Top);

  Shape AddTextbox(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  FreeformBuilder BuildFreeform(MsoEditingType EditingType, float X1, float Y1);
  ShapeRange Range(object Index);
  void SelectAll();
  Shape Background { get; }
}
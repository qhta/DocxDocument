using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface CanvasShapes: InteropDictionary<string, Shape>
{
  public Shape Item(object Index);
  public Shape AddCallout(MsoCalloutType Type, float Left, float Top, float Width, float Height);
  public Shape AddConnector(MsoConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);
  public Shape AddCurve(object SafeArrayOfPoints);
  public Shape AddLabel(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  public Shape AddLine(float BeginX, float BeginY, float EndX, float EndY);

  public Shape AddPicture
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width,
    float Height);

  public Shape AddPolyline(object SafeArrayOfPoints);
  public Shape AddShape(MsoAutoShapeType Type, float Left, float Top, float Width, float Height);

  public Shape AddTextEffect
  (MsoPresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, MsoTriState FontBold,
    MsoTriState FontItalic, float Left, float Top);

  public Shape AddTextbox(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  public FreeformBuilder BuildFreeform(MsoEditingType EditingType, float X1, float Y1);
  public ShapeRange Range(object Index);
  public void SelectAll();
  public Shape Background { get; }
}

using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Shapes: InteropDictionary<string, Shape>
{
  Shape Item(object Index);
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
  Shape Default { get; }
  Shape AddDiagram(MsoDiagramType Type, float Left, float Top, float Width, float Height);
  Shape AddCanvas(float Left, float Top, float Width, float Height);

  Shape AddChart
    (XlChartType Type, float Left, float Top, float Width, float Height);

  Shape AddTable(int NumRows, int NumColumns, float Left, float Top, float Width, float Height);
  Shape AddSmartArt(SmartArtLayout Layout, float Left, float Top, float Width, float Height);

  Shape AddChart2
  (int Style, XlChartType Type, float Left, float Top, float Width,
    float Height, bool NewLayout);

  Shape AddPicture2
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width,
    float Height, MsoPictureCompress Compress);
}
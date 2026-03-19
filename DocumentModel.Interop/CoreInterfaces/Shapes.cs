using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Shapes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  Shape Item(object Index);
  new IEnumerator GetEnumerator();
  Shape AddCallout(MsoCalloutType Type, float Left, float Top, float Width, float Height);
  Shape AddConnector(MsoConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);
  Shape AddCurve(object SafeArrayOfPoints);
  Shape AddLabel(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  Shape AddLine(float BeginX, float BeginY, float EndX, float EndY);

  Shape AddPicture
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width = -1f,
    float Height = -1f);

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
    (XlChartType Type = (XlChartType)(-1), float Left = -1f, float Top = -1f, float Width = -1f, float Height = -1f);

  Shape AddTable(int NumRows, int NumColumns, float Left, float Top, float Width, float Height);
  Shape AddSmartArt(SmartArtLayout Layout, float Left = -1f, float Top = -1f, float Width = -1f, float Height = -1f);

  Shape AddChart2
  (int Style = -1, XlChartType Type = (XlChartType)(-1), float Left = -1f, float Top = -1f, float Width = -1f,
    float Height = -1f, bool NewLayout = true);

  Shape AddPicture2
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width = -1f,
    float Height = -1f, MsoPictureCompress Compress = MsoPictureCompress.msoPictureCompressDocDefault);
}
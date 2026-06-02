using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes?view=office-pia"/>
public partial class Shapes
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.item?view=office-pia"/>
  public Shape Item(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddCallout`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addcallout?view=office-pia"/>
  public Shape AddCallout(CalloutType Type, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddConnector`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="BeginX">The `BeginX` parameter.</param>
  /// <param name="BeginY">The `BeginY` parameter.</param>
  /// <param name="EndX">The `EndX` parameter.</param>
  /// <param name="EndY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addconnector?view=office-pia"/>
  public Shape AddConnector(ConnectorType Type, float BeginX, float BeginY, float EndX, float EndY) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddCurve`.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addcurve?view=office-pia"/>
  public Shape AddCurve(object SafeArrayOfPoints) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddLabel`.
  /// </summary>
  /// <param name="Orientation">The `Orientation` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addlabel?view=office-pia"/>
  public Shape AddLabel(TextOrientation Orientation, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddLine`.
  /// </summary>
  /// <param name="BeginX">The `BeginX` parameter.</param>
  /// <param name="BeginY">The `BeginY` parameter.</param>
  /// <param name="EndX">The `EndX` parameter.</param>
  /// <param name="EndY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addline?view=office-pia"/>
  public Shape AddLine(float BeginX, float BeginY, float EndX, float EndY) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddPicture`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="LinkToFile">The `LinkToFile` parameter.</param>
  /// <param name="SaveWithDocument">The `SaveWithDocument` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addpicture?view=office-pia"/>
  public Shape AddPicture
  (string FileName, TriState LinkToFile, TriState SaveWithDocument, float Left, float Top, float Width,
    float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddPolyline`.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addpolyline?view=office-pia"/>
  public Shape AddPolyline(object SafeArrayOfPoints) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddShape`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addshape?view=office-pia"/>
  public Shape AddShape(AutoShapeType Type, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddTextEffect`.
  /// </summary>
  /// <param name="PresetTextEffect">The `PresetTextEffect` parameter.</param>
  /// <param name="Text">The `Text` parameter.</param>
  /// <param name="FontName">The `FontName` parameter.</param>
  /// <param name="FontSize">The `FontSize` parameter.</param>
  /// <param name="FontBold">The `FontBold` parameter.</param>
  /// <param name="FontItalic">The `FontItalic` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addtexteffect?view=office-pia"/>
  public Shape AddTextEffect
  (PresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, TriState FontBold,
    TriState FontItalic, float Left, float Top)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddTextbox`.
  /// </summary>
  /// <param name="Orientation">The `Orientation` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addtextbox?view=office-pia"/>
  public Shape AddTextbox(TextOrientation Orientation, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `BuildFreeform`.
  /// </summary>
  /// <param name="EditingType">The `EditingType` parameter.</param>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.buildfreeform?view=office-pia"/>
  public FreeformBuilder BuildFreeform(EditingType EditingType, float X1, float Y1) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Range`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.range?view=office-pia"/>
  public ShapeRange Range(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SelectAll`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.selectall?view=office-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddDiagram`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.adddiagram?view=office-pia"/>
  public Shape AddDiagram(DiagramType Type, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddCanvas`.
  /// </summary>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addcanvas?view=office-pia"/>
  public Shape AddCanvas(float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddChart`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addchart?view=office-pia"/>
  public Shape AddChart
    (ChartType Type, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddTable`.
  /// </summary>
  /// <param name="NumRows">The `NumRows` parameter.</param>
  /// <param name="NumColumns">The `NumColumns` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addtable?view=office-pia"/>
  public Shape AddTable(int NumRows, int NumColumns, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddSmartArt`.
  /// </summary>
  /// <param name="Layout">The `Layout` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addsmartart?view=office-pia"/>
  public Shape AddSmartArt(SmartArtLayout Layout, float Left, float Top, float Width, float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddChart2`.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <param name="NewLayout">The `NewLayout` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addchart2?view=office-pia"/>
  public Shape AddChart2
  (int Style, ChartType Type, float Left, float Top, float Width,
    float Height, bool NewLayout) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddPicture2`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="LinkToFile">The `LinkToFile` parameter.</param>
  /// <param name="SaveWithDocument">The `SaveWithDocument` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <param name="Compress">The `Compress` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapes.addpicture2?view=office-pia"/>
  public Shape AddPicture2
  (string FileName, TriState LinkToFile, TriState SaveWithDocument, float Left, float Top, float Width,
    float Height, PictureCompress Compress) { throw new NotImplementedException(); }  
}


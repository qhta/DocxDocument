using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes?view=office-pia"/>
public partial class CanvasShapes: InteropCollection<Shape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.background?view=office-pia"/>
  public Shape Background { get; }


  #region methods

/// <summary>
  /// Returns a shape from the canvas by index or name.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.item?view=office-pia"/>
  public Shape Item(object index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddCallout`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcallout?view=office-pia"/>
  public Shape AddCallout(CalloutType type, float left, float top, float width, float height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddConnector`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="beginX">The `BeginX` parameter.</param>
  /// <param name="beginY">The `BeginY` parameter.</param>
  /// <param name="endX">The `EndX` parameter.</param>
  /// <param name="endY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addconnector?view=office-pia"/>
  public Shape AddConnector(ConnectorType type, float beginX, float beginY, float endX, float endY) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddCurve`.
  /// </summary>
  /// <param name="safeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcurve?view=office-pia"/>
  public Shape AddCurve(object safeArrayOfPoints) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddLabel`.
  /// </summary>
  /// <param name="orientation">The `Orientation` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addlabel?view=office-pia"/>
  public Shape AddLabel(TextOrientation orientation, float left, float top, float width, float height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddLine`.
  /// </summary>
  /// <param name="beginX">The `BeginX` parameter.</param>
  /// <param name="beginY">The `BeginY` parameter.</param>
  /// <param name="endX">The `EndX` parameter.</param>
  /// <param name="endY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addline?view=office-pia"/>
  public Shape AddLine(float beginX, float beginY, float endX, float endY) { throw new NotImplementedException(); }
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
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addpicture?view=office-pia"/>
  public Shape AddPicture
  (string FileName, TriState LinkToFile, TriState SaveWithDocument, float Left, float Top, float Width,
    float Height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddPolyline`.
  /// </summary>
  /// <param name="safeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addpolyline?view=office-pia"/>
  public Shape AddPolyline(object safeArrayOfPoints) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddShape`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addshape?view=office-pia"/>
  public Shape AddShape(AutoShapeType type, float left, float top, float width, float height) { throw new NotImplementedException(); }
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
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addtexteffect?view=office-pia"/>
  public Shape AddTextEffect
  (PresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, TriState FontBold,
    TriState FontItalic, float Left, float Top) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddTextbox`.
  /// </summary>
  /// <param name="orientation">The `Orientation` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addtextbox?view=office-pia"/>
  public Shape AddTextbox(TextOrientation orientation, float left, float top, float width, float height) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `BuildFreeform`.
  /// </summary>
  /// <param name="editingType">The `EditingType` parameter.</param>
  /// <param name="x1">The `X1` parameter.</param>
  /// <param name="y1">The `Y1` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.buildfreeform?view=office-pia"/>
  public FreeformBuilder BuildFreeform(EditingType editingType, float x1, float y1) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Range`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.range?view=office-pia"/>
  public ShapeRange Range(object index) { throw new NotImplementedException(); }
  /// <summary>
  /// Selects all shapes on the drawing canvas.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.selectall?view=office-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }

  #endregion methods
}


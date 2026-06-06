using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes?view=office-pia"/>
public interface ICanvasShapes: IInteropCollection<IShape>
{
  /// <summary>
  /// Gets the `Background` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.background?view=office-pia"/>
  public IShape Background { get; }


  #region methods

/// <summary>
  /// Returns a shape from the canvas by index or name.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.item?view=office-pia"/>
  public IShape Item(object index);
  /// <summary>
  /// Invokes `AddCallout`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcallout?view=office-pia"/>
  public IShape AddCallout(CalloutType type, float left, float top, float width, float height);
  /// <summary>
  /// Invokes `AddConnector`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="beginX">The `BeginX` parameter.</param>
  /// <param name="beginY">The `BeginY` parameter.</param>
  /// <param name="endX">The `EndX` parameter.</param>
  /// <param name="endY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addconnector?view=office-pia"/>
  public IShape AddConnector(ConnectorType type, float beginX, float beginY, float endX, float endY);
  /// <summary>
  /// Invokes `AddCurve`.
  /// </summary>
  /// <param name="safeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcurve?view=office-pia"/>
  public IShape AddCurve(object safeArrayOfPoints);
  /// <summary>
  /// Invokes `AddLabel`.
  /// </summary>
  /// <param name="orientation">The `Orientation` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addlabel?view=office-pia"/>
  public IShape AddLabel(TextOrientation orientation, float left, float top, float width, float height);
  /// <summary>
  /// Invokes `AddLine`.
  /// </summary>
  /// <param name="beginX">The `BeginX` parameter.</param>
  /// <param name="beginY">The `BeginY` parameter.</param>
  /// <param name="endX">The `EndX` parameter.</param>
  /// <param name="endY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addline?view=office-pia"/>
  public IShape AddLine(float beginX, float beginY, float endX, float endY);
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addpicture?view=office-pia"/>
  public IShape AddPicture
  (string FileName, TriState LinkToFile, TriState SaveWithDocument, float Left, float Top, float Width,
    float Height);
  /// <summary>
  /// Invokes `AddPolyline`.
  /// </summary>
  /// <param name="safeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addpolyline?view=office-pia"/>
  public IShape AddPolyline(object safeArrayOfPoints);
  /// <summary>
  /// Invokes `AddShape`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addshape?view=office-pia"/>
  public IShape AddShape(AutoShapeType type, float left, float top, float width, float height);
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addtexteffect?view=office-pia"/>
  public IShape AddTextEffect
  (PresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, TriState FontBold,
    TriState FontItalic, float Left, float Top);
  /// <summary>
  /// Invokes `AddTextbox`.
  /// </summary>
  /// <param name="orientation">The `Orientation` parameter.</param>
  /// <param name="left">The `Left` parameter.</param>
  /// <param name="top">The `Top` parameter.</param>
  /// <param name="width">The `Width` parameter.</param>
  /// <param name="height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addtextbox?view=office-pia"/>
  public IShape AddTextbox(TextOrientation orientation, float left, float top, float width, float height);
  /// <summary>
  /// Invokes `BuildFreeform`.
  /// </summary>
  /// <param name="editingType">The `EditingType` parameter.</param>
  /// <param name="x1">The `X1` parameter.</param>
  /// <param name="y1">The `Y1` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.buildfreeform?view=office-pia"/>
  public IFreeformBuilder BuildFreeform(EditingType editingType, float x1, float y1);
  /// <summary>
  /// Invokes `Range`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.range?view=office-pia"/>
  public IShapeRange Range(object index);
  /// <summary>
  /// Selects all shapes on the drawing canvas.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.selectall?view=office-pia"/>
  public void SelectAll();

  #endregion methods
}


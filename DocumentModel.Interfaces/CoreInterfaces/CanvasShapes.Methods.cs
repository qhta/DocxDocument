using System.Collections;
using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes?view=office-pia"/>
public partial interface CanvasShapes
{
  /// <summary>
  /// Returns a shape from the canvas by index or name.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.item?view=office-pia"/>
  public Shape Item(object Index);
  /// <summary>
  /// Invokes `AddCallout`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcallout?view=office-pia"/>
  public Shape AddCallout(MsoCalloutType Type, float Left, float Top, float Width, float Height);
  /// <summary>
  /// Invokes `AddConnector`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="BeginX">The `BeginX` parameter.</param>
  /// <param name="BeginY">The `BeginY` parameter.</param>
  /// <param name="EndX">The `EndX` parameter.</param>
  /// <param name="EndY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addconnector?view=office-pia"/>
  public Shape AddConnector(MsoConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);
  /// <summary>
  /// Invokes `AddCurve`.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addcurve?view=office-pia"/>
  public Shape AddCurve(object SafeArrayOfPoints);
  /// <summary>
  /// Invokes `AddLabel`.
  /// </summary>
  /// <param name="Orientation">The `Orientation` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addlabel?view=office-pia"/>
  public Shape AddLabel(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  /// <summary>
  /// Invokes `AddLine`.
  /// </summary>
  /// <param name="BeginX">The `BeginX` parameter.</param>
  /// <param name="BeginY">The `BeginY` parameter.</param>
  /// <param name="EndX">The `EndX` parameter.</param>
  /// <param name="EndY">The `EndY` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addline?view=office-pia"/>
  public Shape AddLine(float BeginX, float BeginY, float EndX, float EndY);
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
  public Shape AddPicture
  (string FileName, MsoTriState LinkToFile, MsoTriState SaveWithDocument, float Left, float Top, float Width,
    float Height);
  /// <summary>
  /// Invokes `AddPolyline`.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The `SafeArrayOfPoints` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addpolyline?view=office-pia"/>
  public Shape AddPolyline(object SafeArrayOfPoints);
  /// <summary>
  /// Invokes `AddShape`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addshape?view=office-pia"/>
  public Shape AddShape(MsoAutoShapeType Type, float Left, float Top, float Width, float Height);
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
  public Shape AddTextEffect
  (MsoPresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, MsoTriState FontBold,
    MsoTriState FontItalic, float Left, float Top);
  /// <summary>
  /// Invokes `AddTextbox`.
  /// </summary>
  /// <param name="Orientation">The `Orientation` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Width">The `Width` parameter.</param>
  /// <param name="Height">The `Height` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.addtextbox?view=office-pia"/>
  public Shape AddTextbox(MsoTextOrientation Orientation, float Left, float Top, float Width, float Height);
  /// <summary>
  /// Invokes `BuildFreeform`.
  /// </summary>
  /// <param name="EditingType">The `EditingType` parameter.</param>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.buildfreeform?view=office-pia"/>
  public FreeformBuilder BuildFreeform(MsoEditingType EditingType, float X1, float Y1);
  /// <summary>
  /// Invokes `Range`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.range?view=office-pia"/>
  public ShapeRange Range(object Index);
  /// <summary>
  /// Selects all shapes on the drawing canvas.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.canvasshapes.selectall?view=office-pia"/>
  public void SelectAll();
}


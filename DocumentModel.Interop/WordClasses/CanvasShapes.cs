namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the shapes in a drawing canvas.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes?view=word-pia"/>
public partial class CanvasShapes : InteropCollection<Shape>
{


  #region methods

/// <summary>
  /// Creates a callout shape on the drawing canvas.
  /// </summary>
  /// <param name="type">The callout type.</param>
  /// <param name="left">The position, in points, of the left edge of the shape.</param>
  /// <param name="top">The position, in points, of the top edge of the shape.</param>
  /// <param name="width">The width, in points, of the shape.</param>
  /// <param name="height">The height, in points, of the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addcallout?view=word-pia"/>
  public Shape AddCallout(Core.CalloutType type, float left, float top, float width, float height) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a connector shape on the drawing canvas.
  /// </summary>
  /// <param name="type">The connector type.</param>
  /// <param name="beginX">The x-coordinate, in points, of the connector start point.</param>
  /// <param name="beginY">The y-coordinate, in points, of the connector start point.</param>
  /// <param name="endX">The x-coordinate, in points, of the connector end point.</param>
  /// <param name="endY">The y-coordinate, in points, of the connector end point.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addconnector?view=word-pia"/>
  public Shape AddConnector(Core.ConnectorType type, float beginX, float beginY, float endX, float endY) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a curved shape using the specified points.
  /// </summary>
  /// <param name="safeArrayOfPoints">An array of points that defines the curve path.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addcurve?view=word-pia"/>
  public Shape AddCurve(object safeArrayOfPoints) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a label shape on the drawing canvas.
  /// </summary>
  /// <param name="orientation">The text orientation of the label.</param>
  /// <param name="left">The position, in points, of the left edge of the label.</param>
  /// <param name="top">The position, in points, of the top edge of the label.</param>
  /// <param name="width">The width, in points, of the label.</param>
  /// <param name="height">The height, in points, of the label.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addlabel?view=word-pia"/>
  public Shape AddLabel(Core.TextOrientation orientation, float left, float top, float width, float height) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a line shape on the drawing canvas.
  /// </summary>
  /// <param name="beginX">The x-coordinate, in points, of the line start point.</param>
  /// <param name="beginY">The y-coordinate, in points, of the line start point.</param>
  /// <param name="endX">The x-coordinate, in points, of the line end point.</param>
  /// <param name="endY">The y-coordinate, in points, of the line end point.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addline?view=word-pia"/>
  public Shape AddLine(float beginX, float beginY, float endX, float endY) { throw new NotImplementedException(); }

  /// <summary>
  /// Adds a picture to the drawing canvas.
  /// </summary>
  /// <param name="fileName">The path and file name of the picture.</param>
  /// <param name="linkToFile">Specifies whether to link the picture to the source file.</param>
  /// <param name="saveWithDocument">Specifies whether to save the linked picture with the document.</param>
  /// <param name="left">The position, in points, of the left edge of the picture.</param>
  /// <param name="top">The position, in points, of the top edge of the picture.</param>
  /// <param name="width">The width, in points, of the picture.</param>
  /// <param name="height">The height, in points, of the picture.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addpicture?view=word-pia"/>
  public Shape AddPicture(string fileName, object linkToFile, object saveWithDocument, object left, object top, object width, object height) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a polyline shape using the specified points.
  /// </summary>
  /// <param name="safeArrayOfPoints">An array of points that defines the polyline path.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addpolyline?view=word-pia"/>
  public Shape AddPolyline(object safeArrayOfPoints) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates an AutoShape on the drawing canvas.
  /// </summary>
  /// <param name="type">The AutoShape type.</param>
  /// <param name="left">The position, in points, of the left edge of the shape.</param>
  /// <param name="top">The position, in points, of the top edge of the shape.</param>
  /// <param name="width">The width, in points, of the shape.</param>
  /// <param name="height">The height, in points, of the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addshape?view=word-pia"/>
  public Shape AddShape(int type, float left, float top, float width, float height) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a WordArt text effect on the drawing canvas.
  /// </summary>
  /// <param name="presetTextEffect">The preset text effect style.</param>
  /// <param name="text">The displayed text.</param>
  /// <param name="fontName">The font name.</param>
  /// <param name="fontSize">The font size.</param>
  /// <param name="fontBold">Specifies whether the text is bold.</param>
  /// <param name="fontItalic">Specifies whether the text is italic.</param>
  /// <param name="left">The position, in points, of the left edge of the text effect.</param>
  /// <param name="top">The position, in points, of the top edge of the text effect.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addtexteffect?view=word-pia"/>
  public Shape AddTextEffect(Core.PresetTextEffect presetTextEffect, string text, string fontName, float fontSize, Core.TriState fontBold, Core.TriState fontItalic, float left, float top) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a text box on the drawing canvas.
  /// </summary>
  /// <param name="orientation">The text orientation of the text box.</param>
  /// <param name="left">The position, in points, of the left edge of the text box.</param>
  /// <param name="top">The position, in points, of the top edge of the text box.</param>
  /// <param name="width">The width, in points, of the text box.</param>
  /// <param name="height">The height, in points, of the text box.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addtextbox?view=word-pia"/>
  public Shape AddTextbox(Core.TextOrientation orientation, float left, float top, float width, float height) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a freeform builder for constructing a custom shape.
  /// </summary>
  /// <param name="editingType">The node editing type for the first node.</param>
  /// <param name="x1">The x-coordinate, in points, of the first node.</param>
  /// <param name="y1">The y-coordinate, in points, of the first node.</param>
  /// <returns>A <see cref="FreeformBuilder"/> used to define the custom shape.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.buildfreeform?view=word-pia"/>
  public FreeformBuilder BuildFreeform(Core.EditingType editingType, float x1, float y1) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns one or more shapes from the collection.
  /// </summary>
  /// <param name="index">The index or array of indexes of shapes to return.</param>
  /// <returns>A <see cref="ShapeRange"/> containing the selected shapes.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.range?view=word-pia"/>
  public ShapeRange Range(object index) { throw new NotImplementedException(); }

  /// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.selectall?view=word-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }

  #endregion methods
}

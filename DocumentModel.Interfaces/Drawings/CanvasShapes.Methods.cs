using DocumentModel.Wordprocessing;

namespace DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes?view=word-pia"/>
public partial interface ICanvasShapes : IModelObject
{
  /// <summary>
  /// Creates a callout shape on the drawing canvas.
  /// </summary>
  /// <param name="Type">The callout type.</param>
  /// <param name="Left">The position, in points, of the left edge of the shape.</param>
  /// <param name="Top">The position, in points, of the top edge of the shape.</param>
  /// <param name="Width">The width, in points, of the shape.</param>
  /// <param name="Height">The height, in points, of the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addcallout?view=word-pia"/>
  public IShape AddCallout(Drawings.CalloutType Type, float Left, float Top, float Width, float Height);

  /// <summary>
  /// Creates a connector shape on the drawing canvas.
  /// </summary>
  /// <param name="Type">The connector type.</param>
  /// <param name="BeginX">The x-coordinate, in points, of the connector start point.</param>
  /// <param name="BeginY">The y-coordinate, in points, of the connector start point.</param>
  /// <param name="EndX">The x-coordinate, in points, of the connector end point.</param>
  /// <param name="EndY">The y-coordinate, in points, of the connector end point.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addconnector?view=word-pia"/>
  public IShape AddConnector(Drawings.ConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);

  /// <summary>
  /// Creates a curved shape using the specified points.
  /// </summary>
  /// <param name="SafeArrayOfPoints">An array of points that defines the curve path.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addcurve?view=word-pia"/>
  public IShape AddCurve(object SafeArrayOfPoints);

  /// <summary>
  /// Creates a label shape on the drawing canvas.
  /// </summary>
  /// <param name="Orientation">The text orientation of the label.</param>
  /// <param name="Left">The position, in points, of the left edge of the label.</param>
  /// <param name="Top">The position, in points, of the top edge of the label.</param>
  /// <param name="Width">The width, in points, of the label.</param>
  /// <param name="Height">The height, in points, of the label.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addlabel?view=word-pia"/>
  public IShape AddLabel(TextOrientation Orientation, float Left, float Top, float Width, float Height);

  /// <summary>
  /// Creates a line shape on the drawing canvas.
  /// </summary>
  /// <param name="BeginX">The x-coordinate, in points, of the line start point.</param>
  /// <param name="BeginY">The y-coordinate, in points, of the line start point.</param>
  /// <param name="EndX">The x-coordinate, in points, of the line end point.</param>
  /// <param name="EndY">The y-coordinate, in points, of the line end point.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addline?view=word-pia"/>
  public IShape AddLine(float BeginX, float BeginY, float EndX, float EndY);

  /// <summary>
  /// Adds a picture to the drawing canvas.
  /// </summary>
  /// <param name="FileName">The path and file name of the picture.</param>
  /// <param name="LinkToFile">Specifies whether to link the picture to the source file.</param>
  /// <param name="SaveWithDocument">Specifies whether to save the linked picture with the document.</param>
  /// <param name="Left">The position, in points, of the left edge of the picture.</param>
  /// <param name="Top">The position, in points, of the top edge of the picture.</param>
  /// <param name="Width">The width, in points, of the picture.</param>
  /// <param name="Height">The height, in points, of the picture.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addpicture?view=word-pia"/>
  public IShape AddPicture(string FileName, object LinkToFile, object SaveWithDocument, object Left, object Top, object Width, object Height);

  /// <summary>
  /// Creates a polyline shape using the specified points.
  /// </summary>
  /// <param name="SafeArrayOfPoints">An array of points that defines the polyline path.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addpolyline?view=word-pia"/>
  public IShape AddPolyline(object SafeArrayOfPoints);

  /// <summary>
  /// Creates an AutoShape on the drawing canvas.
  /// </summary>
  /// <param name="Type">The AutoShape type.</param>
  /// <param name="Left">The position, in points, of the left edge of the shape.</param>
  /// <param name="Top">The position, in points, of the top edge of the shape.</param>
  /// <param name="Width">The width, in points, of the shape.</param>
  /// <param name="Height">The height, in points, of the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addshape?view=word-pia"/>
  public IShape AddShape(int Type, float Left, float Top, float Width, float Height);

  /// <summary>
  /// Creates a WordArt text effect on the drawing canvas.
  /// </summary>
  /// <param name="PresetTextEffect">The preset text effect style.</param>
  /// <param name="Text">The displayed text.</param>
  /// <param name="FontName">The font name.</param>
  /// <param name="FontSize">The font size.</param>
  /// <param name="FontBold">Specifies whether the text is bold.</param>
  /// <param name="FontItalic">Specifies whether the text is italic.</param>
  /// <param name="Left">The position, in points, of the left edge of the text effect.</param>
  /// <param name="Top">The position, in points, of the top edge of the text effect.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addtexteffect?view=word-pia"/>
  public IShape AddTextEffect(Drawings.PresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, TriState FontBold, TriState FontItalic, float Left, float Top);

  /// <summary>
  /// Creates a text box on the drawing canvas.
  /// </summary>
  /// <param name="Orientation">The text orientation of the text box.</param>
  /// <param name="Left">The position, in points, of the left edge of the text box.</param>
  /// <param name="Top">The position, in points, of the top edge of the text box.</param>
  /// <param name="Width">The width, in points, of the text box.</param>
  /// <param name="Height">The height, in points, of the text box.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.addtextbox?view=word-pia"/>
  public IShape AddTextbox(TextOrientation Orientation, float Left, float Top, float Width, float Height);

  /// <summary>
  /// Creates a freeform builder for constructing a custom shape.
  /// </summary>
  /// <param name="EditingType">The node editing type for the first node.</param>
  /// <param name="X1">The x-coordinate, in points, of the first node.</param>
  /// <param name="Y1">The y-coordinate, in points, of the first node.</param>
  /// <returns>A <see cref="IFreeformBuilder"/> used to define the custom shape.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.buildfreeform?view=word-pia"/>
  public IFreeformBuilder BuildFreeform(Drawings.EditingType EditingType, float X1, float Y1);

  /// <summary>
  /// Returns one or more shapes from the collection.
  /// </summary>
  /// <param name="Index">The index or array of indexes of shapes to return.</param>
  /// <returns>A <see cref="IShapeRange"/> containing the selected shapes.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.range?view=word-pia"/>
  public IShapeRange Range(object Index);

  /// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes.selectall?view=word-pia"/>
  public void SelectAll();
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Shape objects that represent all the shapes in a document or all the shapes in all the headers
/// and footers in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes?view=word-pia"/>
public interface IShapes : IInteropObject, IInteropCollection<IShape>
{


  #region methods

/// <summary>
  /// Adds a callout shape to the collection.
  /// </summary>
  /// <param name="type">The callout type.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addcallout?view=word-pia"/>
  public IShape AddCallout(Core.CalloutType type, float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Adds a connector shape to the collection.
  /// </summary>
  /// <param name="type">The connector type.</param>
  /// <param name="beginX">The starting x-coordinate.</param>
  /// <param name="beginY">The starting y-coordinate.</param>
  /// <param name="endX">The ending x-coordinate.</param>
  /// <param name="endY">The ending y-coordinate.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addconnector?view=word-pia"/>
  public IShape AddConnector(Core.ConnectorType type, float beginX, float beginY, float endX, float endY);

  /// <summary>
  /// Adds a curve shape to the collection.
  /// </summary>
  /// <param name="safeArrayOfPoints">The array of points for the curve.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addcurve?view=word-pia"/>
  public IShape AddCurve(object safeArrayOfPoints, object anchor);

  /// <summary>
  /// Adds a label shape to the collection.
  /// </summary>
  /// <param name="orientation">The text orientation.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addlabel?view=word-pia"/>
  public IShape AddLabel(Core.TextOrientation orientation, float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Adds a line shape to the collection.
  /// </summary>
  /// <param name="beginX">The starting x-coordinate.</param>
  /// <param name="beginY">The starting y-coordinate.</param>
  /// <param name="endX">The ending x-coordinate.</param>
  /// <param name="endY">The ending y-coordinate.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addline?view=word-pia"/>
  public IShape AddLine(float beginX, float beginY, float endX, float endY, object anchor);

  /// <summary>
  /// Adds a picture to the collection as a shape.
  /// </summary>
  /// <param name="fileName">The file name of the picture.</param>
  /// <param name="linkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="saveWithDocument">true to save with the document; otherwise, false.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addpicture?view=word-pia"/>
  public IShape AddPicture(string fileName, object linkToFile, object saveWithDocument, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds a polyline shape to the collection.
  /// </summary>
  /// <param name="safeArrayOfPoints">The array of points for the polyline.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addpolyline?view=word-pia"/>
  public IShape AddPolyline(object safeArrayOfPoints, object anchor);

  /// <summary>
  /// Adds a shape to the collection.
  /// </summary>
  /// <param name="type">The type of shape to add.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addshape?view=word-pia"/>
  public IShape AddShape(int type, float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Adds a text effect shape to the collection.
  /// </summary>
  /// <param name="presetTextEffect">The preset text effect.</param>
  /// <param name="text">The text for the effect.</param>
  /// <param name="fontName">The font name.</param>
  /// <param name="fontSize">The font size.</param>
  /// <param name="fontBold">true for bold font; otherwise, false.</param>
  /// <param name="fontItalic">true for italic font; otherwise, false.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addtexteffect?view=word-pia"/>
  public IShape AddTextEffect(Core.PresetTextEffect presetTextEffect, string text, string fontName, float fontSize, Core.TriState fontBold, Core.TriState fontItalic, float left, float top, object anchor);

  /// <summary>
  /// Adds a textbox shape to the collection.
  /// </summary>
  /// <param name="orientation">The text orientation.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addtextbox?view=word-pia"/>
  public IShape AddTextbox(Core.TextOrientation orientation, float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Builds a freeform shape and adds it to the collection.
  /// </summary>
  /// <param name="editingType">The editing type for the freeform.</param>
  /// <param name="x1">The x-coordinate of the first point.</param>
  /// <param name="y1">The y-coordinate of the first point.</param>
  /// <returns>The created <see cref="IFreeformBuilder"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.buildfreeform?view=word-pia"/>
  public IFreeformBuilder BuildFreeform(Core.EditingType editingType, float x1, float y1);

  /// <summary>
  /// Returns a range of shapes from the collection.
  /// </summary>
  /// <param name="index">The index or array of indexes of the shapes to include in the range.</param>
  /// <returns>The <see cref="IShapeRange"/> object representing the range.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.range?view=word-pia"/>
  public IShapeRange Range(object index);

  /// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.selectall?view=word-pia"/>
  public void SelectAll();

  /// <summary>
  /// Adds an OLE object to the collection as a shape.
  /// </summary>
  /// <param name="classType">The class type of the OLE object.</param>
  /// <param name="fileName">The file name of the OLE object.</param>
  /// <param name="linkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="displayAsIcon">true to display as an icon; otherwise, false.</param>
  /// <param name="iconFileName">The file name of the icon.</param>
  /// <param name="iconIndex">The index of the icon.</param>
  /// <param name="iconLabel">The label for the icon.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addoleobject?view=word-pia"/>
  public IShape AddOLEObject(object classType, object fileName, object linkToFile, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds an OLE control to the collection as a shape.
  /// </summary>
  /// <param name="classType">The class type of the OLE control.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addolecontrol?view=word-pia"/>
  public IShape AddOLEControl(object classType, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds a diagram to the collection as a shape.
  /// </summary>
  /// <param name="type">The diagram type.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.adddiagram?view=word-pia"/>
  public IShape AddDiagram(Core.DiagramType type, float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Adds a canvas to the collection as a shape.
  /// </summary>
  /// <param name="left">The left position of the canvas.</param>
  /// <param name="top">The top position of the canvas.</param>
  /// <param name="width">The width of the canvas.</param>
  /// <param name="height">The height of the canvas.</param>
  /// <param name="anchor">The anchor for the canvas.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addcanvas?view=word-pia"/>
  public IShape AddCanvas(float left, float top, float width, float height, object anchor);

  /// <summary>
  /// Adds a chart to the collection as a shape.
  /// </summary>
  /// <param name="type">The chart type.</param>
  /// <param name="left">The left position of the chart.</param>
  /// <param name="top">The top position of the chart.</param>
  /// <param name="width">The width of the chart.</param>
  /// <param name="height">The height of the chart.</param>
  /// <param name="anchor">The anchor for the chart.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addchart?view=word-pia"/>
  public IShape AddChart(object type, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds a SmartArt graphic to the collection as a shape.
  /// </summary>
  /// <param name="layout">The SmartArt layout.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addsmartart?view=word-pia"/>
  public IShape AddSmartArt(object layout, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds a web video to the collection as a shape.
  /// </summary>
  /// <param name="embedCode">The embed code for the web video.</param>
  /// <param name="videoWidth">The width of the video.</param>
  /// <param name="videoHeight">The height of the video.</param>
  /// <param name="posterFrameImage">The image to use as the poster frame.</param>
  /// <param name="url">The URL of the video.</param>
  /// <param name="left">The left position of the shape.</param>
  /// <param name="top">The top position of the shape.</param>
  /// <param name="width">The width of the shape.</param>
  /// <param name="height">The height of the shape.</param>
  /// <param name="anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addwebvideo?view=word-pia"/>
  public IShape AddWebVideo(string embedCode, object videoWidth, object videoHeight, object posterFrameImage, object url, object left, object top, object width, object height, object anchor);

  /// <summary>
  /// Adds a chart to the collection as a shape using the specified style and layout.
  /// </summary>
  /// <param name="style">The chart style.</param>
  /// <param name="type">The chart type.</param>
  /// <param name="left">The left position of the chart.</param>
  /// <param name="top">The top position of the chart.</param>
  /// <param name="width">The width of the chart.</param>
  /// <param name="height">The height of the chart.</param>
  /// <param name="anchor">The anchor for the chart.</param>
  /// <param name="newLayout">The new layout for the chart.</param>
  /// <returns>The created <see cref="IShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes.addchart2?view=word-pia"/>
  public IShape AddChart2(int style, object type, object left, object top, object width, object height, object anchor, object newLayout);

  #endregion methods
}

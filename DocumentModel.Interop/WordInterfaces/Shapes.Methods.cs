namespace DocumentModel.Interop.Word;

public partial interface Shapes
{
  /// <summary>
  /// Adds a callout shape to the collection.
  /// </summary>
  /// <param name="Type">The callout type.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddCallout(Core.MsoCalloutType Type, float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Adds a connector shape to the collection.
  /// </summary>
  /// <param name="Type">The connector type.</param>
  /// <param name="BeginX">The starting x-coordinate.</param>
  /// <param name="BeginY">The starting y-coordinate.</param>
  /// <param name="EndX">The ending x-coordinate.</param>
  /// <param name="EndY">The ending y-coordinate.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddConnector(Core.MsoConnectorType Type, float BeginX, float BeginY, float EndX, float EndY);

  /// <summary>
  /// Adds a curve shape to the collection.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The array of points for the curve.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddCurve(object SafeArrayOfPoints, object Anchor);

  /// <summary>
  /// Adds a label shape to the collection.
  /// </summary>
  /// <param name="Orientation">The text orientation.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddLabel(Core.MsoTextOrientation Orientation, float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Adds a line shape to the collection.
  /// </summary>
  /// <param name="BeginX">The starting x-coordinate.</param>
  /// <param name="BeginY">The starting y-coordinate.</param>
  /// <param name="EndX">The ending x-coordinate.</param>
  /// <param name="EndY">The ending y-coordinate.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddLine(float BeginX, float BeginY, float EndX, float EndY, object Anchor);

  /// <summary>
  /// Adds a picture to the collection as a shape.
  /// </summary>
  /// <param name="FileName">The file name of the picture.</param>
  /// <param name="LinkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="SaveWithDocument">true to save with the document; otherwise, false.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddPicture(string FileName, object LinkToFile, object SaveWithDocument, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds a polyline shape to the collection.
  /// </summary>
  /// <param name="SafeArrayOfPoints">The array of points for the polyline.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddPolyline(object SafeArrayOfPoints, object Anchor);

  /// <summary>
  /// Adds a shape to the collection.
  /// </summary>
  /// <param name="Type">The type of shape to add.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddShape(int Type, float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Adds a text effect shape to the collection.
  /// </summary>
  /// <param name="PresetTextEffect">The preset text effect.</param>
  /// <param name="Text">The text for the effect.</param>
  /// <param name="FontName">The font name.</param>
  /// <param name="FontSize">The font size.</param>
  /// <param name="FontBold">true for bold font; otherwise, false.</param>
  /// <param name="FontItalic">true for italic font; otherwise, false.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddTextEffect(Core.MsoPresetTextEffect PresetTextEffect, string Text, string FontName, float FontSize, Core.MsoTriState FontBold, Core.MsoTriState FontItalic, float Left, float Top, object Anchor);

  /// <summary>
  /// Adds a textbox shape to the collection.
  /// </summary>
  /// <param name="Orientation">The text orientation.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddTextbox(Core.MsoTextOrientation Orientation, float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Builds a freeform shape and adds it to the collection.
  /// </summary>
  /// <param name="EditingType">The editing type for the freeform.</param>
  /// <param name="X1">The x-coordinate of the first point.</param>
  /// <param name="Y1">The y-coordinate of the first point.</param>
  /// <returns>The created <see cref="FreeformBuilder"/> object.</returns>
  public FreeformBuilder BuildFreeform(Core.MsoEditingType EditingType, float X1, float Y1);

  /// <summary>
  /// Returns a range of shapes from the collection.
  /// </summary>
  /// <param name="Index">The index or array of indexes of the shapes to include in the range.</param>
  /// <returns>The <see cref="ShapeRange"/> object representing the range.</returns>
  public ShapeRange Range(object Index);

  /// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  public void SelectAll();

  /// <summary>
  /// Adds an OLE object to the collection as a shape.
  /// </summary>
  /// <param name="ClassType">The class type of the OLE object.</param>
  /// <param name="FileName">The file name of the OLE object.</param>
  /// <param name="LinkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="DisplayAsIcon">true to display as an icon; otherwise, false.</param>
  /// <param name="IconFileName">The file name of the icon.</param>
  /// <param name="IconIndex">The index of the icon.</param>
  /// <param name="IconLabel">The label for the icon.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddOLEObject(object ClassType, object FileName, object LinkToFile, object DisplayAsIcon, object IconFileName, object IconIndex, object IconLabel, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds an OLE control to the collection as a shape.
  /// </summary>
  /// <param name="ClassType">The class type of the OLE control.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddOLEControl(object ClassType, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds a diagram to the collection as a shape.
  /// </summary>
  /// <param name="Type">The diagram type.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddDiagram(Core.MsoDiagramType Type, float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Adds a canvas to the collection as a shape.
  /// </summary>
  /// <param name="Left">The left position of the canvas.</param>
  /// <param name="Top">The top position of the canvas.</param>
  /// <param name="Width">The width of the canvas.</param>
  /// <param name="Height">The height of the canvas.</param>
  /// <param name="Anchor">The anchor for the canvas.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddCanvas(float Left, float Top, float Width, float Height, object Anchor);

  /// <summary>
  /// Adds a chart to the collection as a shape.
  /// </summary>
  /// <param name="Type">The chart type.</param>
  /// <param name="Left">The left position of the chart.</param>
  /// <param name="Top">The top position of the chart.</param>
  /// <param name="Width">The width of the chart.</param>
  /// <param name="Height">The height of the chart.</param>
  /// <param name="Anchor">The anchor for the chart.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddChart(object Type, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds a SmartArt graphic to the collection as a shape.
  /// </summary>
  /// <param name="Layout">The SmartArt layout.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddSmartArt(object Layout, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds a web video to the collection as a shape.
  /// </summary>
  /// <param name="EmbedCode">The embed code for the web video.</param>
  /// <param name="VideoWidth">The width of the video.</param>
  /// <param name="VideoHeight">The height of the video.</param>
  /// <param name="PosterFrameImage">The image to use as the poster frame.</param>
  /// <param name="Url">The URL of the video.</param>
  /// <param name="Left">The left position of the shape.</param>
  /// <param name="Top">The top position of the shape.</param>
  /// <param name="Width">The width of the shape.</param>
  /// <param name="Height">The height of the shape.</param>
  /// <param name="Anchor">The anchor for the shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddWebVideo(string EmbedCode, object VideoWidth, object VideoHeight, object PosterFrameImage, object Url, object Left, object Top, object Width, object Height, object Anchor);

  /// <summary>
  /// Adds a chart to the collection as a shape using the specified style and layout.
  /// </summary>
  /// <param name="Style">The chart style.</param>
  /// <param name="Type">The chart type.</param>
  /// <param name="Left">The left position of the chart.</param>
  /// <param name="Top">The top position of the chart.</param>
  /// <param name="Width">The width of the chart.</param>
  /// <param name="Height">The height of the chart.</param>
  /// <param name="Anchor">The anchor for the chart.</param>
  /// <param name="NewLayout">The new layout for the chart.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape AddChart2(int Style, object Type, object Left, object Top, object Width, object Height, object Anchor, object NewLayout);
}

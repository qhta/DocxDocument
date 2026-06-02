namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes?view=word-pia"/>
public partial interface IInlineShapes
{
  /// <summary>
  /// Adds a picture to the document as an inline shape.
  /// </summary>
  /// <param name="FileName">The file name of the picture.</param>
  /// <param name="LinkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="SaveWithDocument">true to save the picture with the document; otherwise, false.</param>
  /// <param name="Range">The range where the picture is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addpicture?view=word-pia"/>
  public InlineShape AddPicture(string FileName, object LinkToFile, object SaveWithDocument, object Range);

  /// <summary>
  /// Adds an OLE object to the document as an inline shape.
  /// </summary>
  /// <param name="ClassType">The class type of the OLE object.</param>
  /// <param name="FileName">The file name of the OLE object.</param>
  /// <param name="LinkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="DisplayAsIcon">true to display as an icon; otherwise, false.</param>
  /// <param name="IconFileName">The file name of the icon.</param>
  /// <param name="IconIndex">The index of the icon.</param>
  /// <param name="IconLabel">The label for the icon.</param>
  /// <param name="Range">The range where the OLE object is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addoleobject?view=word-pia"/>
  public InlineShape AddOLEObject(object ClassType, object FileName, object LinkToFile, object DisplayAsIcon, object IconFileName, object IconIndex, object IconLabel, object Range);

  /// <summary>
  /// Adds an OLE control to the document as an inline shape.
  /// </summary>
  /// <param name="ClassType">The class type of the OLE control.</param>
  /// <param name="Range">The range where the OLE control is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addolecontrol?view=word-pia"/>
  public InlineShape AddOLEControl(object ClassType, object Range);

  /// <summary>
  /// Adds a new inline shape at the specified range.
  /// </summary>
  /// <param name="Range">The range where the inline shape is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.new?view=word-pia"/>
  public InlineShape New(Range Range);

  /// <summary>
  /// Adds a horizontal line to the document as an inline shape.
  /// </summary>
  /// <param name="FileName">The file name of the horizontal line image.</param>
  /// <param name="Range">The range where the horizontal line is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addhorizontalline?view=word-pia"/>
  public InlineShape AddHorizontalLine(string FileName, object Range);

  /// <summary>
  /// Adds a standard horizontal line to the document as an inline shape.
  /// </summary>
  /// <param name="Range">The range where the horizontal line is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addhorizontallinestandard?view=word-pia"/>
  public InlineShape AddHorizontalLineStandard(object Range);

  /// <summary>
  /// Adds a picture bullet to the document as an inline shape.
  /// </summary>
  /// <param name="FileName">The file name of the picture bullet.</param>
  /// <param name="Range">The range where the picture bullet is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addpicturebullet?view=word-pia"/>
  public InlineShape AddPictureBullet(string FileName, object Range);

  /// <summary>
  /// Adds a chart to the document as an inline shape.
  /// </summary>
  /// <param name="Type">The chart type.</param>
  /// <param name="Range">The range where the chart is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addchart?view=word-pia"/>
  public InlineShape AddChart(object Type, object Range);

  /// <summary>
  /// Adds a SmartArt graphic to the document as an inline shape.
  /// </summary>
  /// <param name="Layout">The SmartArt layout.</param>
  /// <param name="Range">The range where the SmartArt is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addsmartart?view=word-pia"/>
  public InlineShape AddSmartArt(object Layout, object Range);

  /// <summary>
  /// Adds a web video to the document as an inline shape.
  /// </summary>
  /// <param name="EmbedCode">The embed code for the web video.</param>
  /// <param name="VideoWidth">The width of the video.</param>
  /// <param name="VideoHeight">The height of the video.</param>
  /// <param name="PosterFrameImage">The image to use as the poster frame.</param>
  /// <param name="Url">The URL of the video.</param>
  /// <param name="Range">The range where the web video is inserted.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addwebvideo?view=word-pia"/>
  public InlineShape AddWebVideo(string EmbedCode, object VideoWidth, object VideoHeight, object PosterFrameImage, object Url, object Range);

  /// <summary>
  /// Adds a chart to the document as an inline shape using the specified style and layout.
  /// </summary>
  /// <param name="Style">The chart style.</param>
  /// <param name="Type">The chart type.</param>
  /// <param name="Range">The range where the chart is inserted.</param>
  /// <param name="NewLayout">The new layout for the chart.</param>
  /// <returns>The created <see cref="InlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addchart2?view=word-pia"/>
  public InlineShape AddChart2(int Style, object Type, object Range, object NewLayout);
}

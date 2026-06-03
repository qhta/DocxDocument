namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of IInlineShape objects that represent all the inline shapes in a document, range, or selection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes?view=word-pia"/>
public interface IInlineShapes : IInteropObject, IInteropCollection<IInlineShape>
{


  #region methods

/// <summary>
  /// Adds a picture to the document as an inline shape.
  /// </summary>
  /// <param name="fileName">The file name of the picture.</param>
  /// <param name="linkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="saveWithDocument">true to save the picture with the document; otherwise, false.</param>
  /// <param name="range">The range where the picture is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addpicture?view=word-pia"/>
  public IInlineShape AddPicture(string fileName, object linkToFile, object saveWithDocument, object range);

  /// <summary>
  /// Adds an OLE object to the document as an inline shape.
  /// </summary>
  /// <param name="classType">The class type of the OLE object.</param>
  /// <param name="fileName">The file name of the OLE object.</param>
  /// <param name="linkToFile">true to link to the file; otherwise, false.</param>
  /// <param name="displayAsIcon">true to display as an icon; otherwise, false.</param>
  /// <param name="iconFileName">The file name of the icon.</param>
  /// <param name="iconIndex">The index of the icon.</param>
  /// <param name="iconLabel">The label for the icon.</param>
  /// <param name="range">The range where the OLE object is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addoleobject?view=word-pia"/>
  public IInlineShape AddOLEObject(object classType, object fileName, object linkToFile, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel, object range);

  /// <summary>
  /// Adds an OLE control to the document as an inline shape.
  /// </summary>
  /// <param name="classType">The class type of the OLE control.</param>
  /// <param name="range">The range where the OLE control is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addolecontrol?view=word-pia"/>
  public IInlineShape AddOLEControl(object classType, object range);

  /// <summary>
  /// Adds a new inline shape at the specified range.
  /// </summary>
  /// <param name="range">The range where the inline shape is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.new?view=word-pia"/>
  public IInlineShape New(IRange range);

  /// <summary>
  /// Adds a horizontal line to the document as an inline shape.
  /// </summary>
  /// <param name="fileName">The file name of the horizontal line image.</param>
  /// <param name="range">The range where the horizontal line is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addhorizontalline?view=word-pia"/>
  public IInlineShape AddHorizontalLine(string fileName, object range);

  /// <summary>
  /// Adds a standard horizontal line to the document as an inline shape.
  /// </summary>
  /// <param name="range">The range where the horizontal line is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addhorizontallinestandard?view=word-pia"/>
  public IInlineShape AddHorizontalLineStandard(object range);

  /// <summary>
  /// Adds a picture bullet to the document as an inline shape.
  /// </summary>
  /// <param name="fileName">The file name of the picture bullet.</param>
  /// <param name="range">The range where the picture bullet is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addpicturebullet?view=word-pia"/>
  public IInlineShape AddPictureBullet(string fileName, object range);

  /// <summary>
  /// Adds a chart to the document as an inline shape.
  /// </summary>
  /// <param name="type">The chart type.</param>
  /// <param name="range">The range where the chart is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addchart?view=word-pia"/>
  public IInlineShape AddChart(object type, object range);

  /// <summary>
  /// Adds a SmartArt graphic to the document as an inline shape.
  /// </summary>
  /// <param name="layout">The SmartArt layout.</param>
  /// <param name="range">The range where the SmartArt is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addsmartart?view=word-pia"/>
  public IInlineShape AddSmartArt(object layout, object range);

  /// <summary>
  /// Adds a web video to the document as an inline shape.
  /// </summary>
  /// <param name="embedCode">The embed code for the web video.</param>
  /// <param name="videoWidth">The width of the video.</param>
  /// <param name="videoHeight">The height of the video.</param>
  /// <param name="posterFrameImage">The image to use as the poster frame.</param>
  /// <param name="url">The URL of the video.</param>
  /// <param name="range">The range where the web video is inserted.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addwebvideo?view=word-pia"/>
  public IInlineShape AddWebVideo(string embedCode, object videoWidth, object videoHeight, object posterFrameImage, object url, object range);

  /// <summary>
  /// Adds a chart to the document as an inline shape using the specified style and layout.
  /// </summary>
  /// <param name="style">The chart style.</param>
  /// <param name="type">The chart type.</param>
  /// <param name="range">The range where the chart is inserted.</param>
  /// <param name="newLayout">The new layout for the chart.</param>
  /// <returns>The created <see cref="IInlineShape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes.addchart2?view=word-pia"/>
  public IInlineShape AddChart2(int style, object type, object range, object newLayout);

  #endregion methods
}

/// <summary>
/// Standard Windows clipboard format constants used in VClipboardData.
/// </summary>
public static class ClipboardFormat
{
  /// <summary>CF_TEXT - Text format (ANSI)</summary>
  public const int CF_TEXT = 1;
  
  /// <summary>CF_BITMAP - Bitmap format (handle to GDI bitmap object)</summary>
  public const int CF_BITMAP = 2;
  
  /// <summary>CF_METAFILEPICT - Metafile picture format (handle to METAFILEPICT structure)</summary>
  public const int CF_METAFILEPICT = 3;
  
  /// <summary>CF_SYLK - Microsoft Symbolic Link format</summary>
  public const int CF_SYLK = 4;
  
  /// <summary>CF_DIF - Data Interchange Format</summary>
  public const int CF_DIF = 5;
  
  /// <summary>CF_TIFF - Tagged Image File Format</summary>
  public const int CF_TIFF = 6;
  
  /// <summary>CF_OEMTEXT - OEM text format</summary>
  public const int CF_OEMTEXT = 7;
  
  /// <summary>CF_DIB - Device Independent Bitmap (BITMAPINFO structure + bitmap bits)</summary>
  public const int CF_DIB = 8;
  
  /// <summary>CF_PALETTE - Color palette (handle to logical color palette)</summary>
  public const int CF_PALETTE = 9;
  
  /// <summary>CF_PENDATA - Pen computing data</summary>
  public const int CF_PENDATA = 10;
  
  /// <summary>CF_RIFF - Audio data in RIFF format</summary>
  public const int CF_RIFF = 11;
  
  /// <summary>CF_WAVE - Audio data in WAVE format</summary>
  public const int CF_WAVE = 12;
  
  /// <summary>CF_UNICODETEXT - Unicode text format</summary>
  public const int CF_UNICODETEXT = 13;
  
  /// <summary>CF_ENHMETAFILE - Enhanced metafile format (handle to enhanced metafile)</summary>
  public const int CF_ENHMETAFILE = 14;
  
  /// <summary>CF_HDROP - File drop format (list of files)</summary>
  public const int CF_HDROP = 15;
  
  /// <summary>CF_LOCALE - Locale identifier associated with text</summary>
  public const int CF_LOCALE = 16;
  
  /// <summary>CF_DIBV5 - Device Independent Bitmap version 5 (BITMAPV5HEADER structure)</summary>
  public const int CF_DIBV5 = 17;
  
  /// <summary>CF_OWNERDISPLAY - Owner-display format</summary>
  public const int CF_OWNERDISPLAY = 0x0080;
  
  /// <summary>CF_DSPTEXT - Display text format (private format for display only)</summary>
  public const int CF_DSPTEXT = 0x0081;
  
  /// <summary>CF_DSPBITMAP - Display bitmap format (private format for display only)</summary>
  public const int CF_DSPBITMAP = 0x0082;
  
  /// <summary>CF_DSPMETAFILEPICT - Display metafile picture format (private format for display only)</summary>
  public const int CF_DSPMETAFILEPICT = 0x0083;
  
  /// <summary>CF_DSPENHMETAFILE - Display enhanced metafile format (private format for display only)</summary>
  public const int CF_DSPENHMETAFILE = 0x008E;
  
  /// <summary>Starting value for private/custom clipboard formats (registered with RegisterClipboardFormat)</summary>
  public const int CF_PRIVATEFIRST = 0x0200;
  
  /// <summary>Ending value for private/custom clipboard formats</summary>
  public const int CF_PRIVATELAST = 0x02FF;
  
  /// <summary>Starting value for globally registered clipboard formats</summary>
  public const int CF_GDIOBJFIRST = 0x0300;
  
  /// <summary>Ending value for globally registered clipboard formats</summary>
  public const int CF_GDIOBJLAST = 0x03FF;
}
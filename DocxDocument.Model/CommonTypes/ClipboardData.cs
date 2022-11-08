namespace DocxDocument.Model;

public class ClipboardDataFormat
{
  public const string CommaSeparatedValue = "CSV";
  public const string Dib = "DeviceIndependentBitmap";
  public const string Dif = "DataInterchangeFormat";
  public const string EnhancedMetafile = "EnhancedMetafile";
  public const string FileDrop = "FileDrop";
  public const string Html = "HTML Format";
  public const string Locale = "Locale";
  public const string MetafilePicture = "MetaFilePict";
  public const string OemText = "OEMText";
  public const string Palette = "Palette";
  public const string PenData = "PenData";
  public const string Riff = "RiffAudio";
  public const string Rtf = "Rich Text Format";
  public const string Serializable = "PersistentObject";
  public const string StringFormat = "System.String";
  public const string SymbolicLink = "SymbolicLink";
  public const string Text = "Text";
  public const string Tiff = "TaggedImageFileFormat";
  public const string UnicodeText = "UnicodeText";
  public const string WaveAudio = "WaveAudio";
  public const string Xaml = "Xaml";
  public const string XamlPackage = "XamlPackage";
}

public struct ClipboardData
{
  public string Format { get; set; }
  public byte[] Data { get; set; }
}
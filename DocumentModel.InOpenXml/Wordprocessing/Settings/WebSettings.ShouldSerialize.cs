namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class WebSettings
{
  public bool ShouldSerializeFrameset() => Frameset is not null && ShouldSerialize(Frameset);
  public bool ShouldSerializeDivs() => Divs is not null && ShouldSerialize(Divs);
  public bool ShouldSerializeWebPageEncoding() => !String.IsNullOrEmpty(WebPageEncoding);
  public bool ShouldSerializeOptimizeForBrowser() => OptimizeForBrowser is not null;
  public bool ShouldSerializeRelyOnVML() => RelyOnVML is not null;
  public bool ShouldSerializeAllowPNG() => AllowPNG is not null;
  public bool ShouldSerializeDoNotRelyOnCSS() => DoNotRelyOnCSS is not null;
  public bool ShouldSerializeDoNotSaveAsSingleFile() => DoNotSaveAsSingleFile is not null;
  public bool ShouldSerializeDoNotOrganizeInFolder() => DoNotOrganizeInFolder is not null;
  public bool ShouldSerializeDoNotUseLongFileNames() => DoNotUseLongFileNames is not null;
  public bool ShouldSerializePixelsPerInch() => PixelsPerInch is not null;
  public bool ShouldSerializeTargetScreenSize() => TargetScreenSize is not null && ShouldSerialize(TargetScreenSize);
}


namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IConverter` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IConverter
{
  /// <summary>
  /// Invokes `HrInitConverter`.
  /// </summary>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrinitconverter?view=office-pia
  /// </remarks>
  public void HrInitConverter
    (IConverterApplicationPreferences pcap, out IConverterPreferences ppcp, IConverterUICallback pcuic);
  /// <summary>
  /// Invokes `HrUninitConverter`.
  /// </summary>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hruninitconverter?view=office-pia
  /// </remarks>
  public void HrUninitConverter(IConverterUICallback pcuic);
  /// <summary>
  /// Invokes `HrImport`.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrimport?view=office-pia
  /// </remarks>
  public void HrImport
  (string bstrSourcePath, string bstrDestPath, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);
  /// <summary>
  /// Invokes `HrExport`.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="bstrClass">The `bstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrexport?view=office-pia
  /// </remarks>
  public void HrExport
  (string bstrSourcePath, string bstrDestPath, string bstrClass, IConverterApplicationPreferences pcap,
    out IConverterPreferences ppcp, IConverterUICallback pcuic);
  /// <summary>
  /// Invokes `HrGetFormat`.
  /// </summary>
  /// <param name="bstrPath">The `bstrPath` parameter.</param>
  /// <param name="pbstrClass">The `pbstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgetformat?view=office-pia
  /// </remarks>
  public void HrGetFormat
  (string bstrPath, out string pbstrClass, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);
  /// <summary>
  /// Invokes `HrGetErrorString`.
  /// </summary>
  /// <param name="hrErr">The `hrErr` parameter.</param>
  /// <param name="pbstrErrorMsg">The `pbstrErrorMsg` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgeterrorstring?view=office-pia
  /// </remarks>
  public void HrGetErrorString(int hrErr, out string pbstrErrorMsg, IConverterApplicationPreferences pcap);
}

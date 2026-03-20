
namespace DocumentModel.Interop.Core;

public interface IConverter
{
  public void HrInitConverter
    (IConverterApplicationPreferences pcap, out IConverterPreferences ppcp, IConverterUICallback pcuic);

  public void HrUninitConverter(IConverterUICallback pcuic);

  public void HrImport
  (string bstrSourcePath, string bstrDestPath, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);

  public void HrExport
  (string bstrSourcePath, string bstrDestPath, string bstrClass, IConverterApplicationPreferences pcap,
    out IConverterPreferences ppcp, IConverterUICallback pcuic);

  public void HrGetFormat
  (string bstrPath, out string pbstrClass, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);

  public void HrGetErrorString(int hrErr, out string pbstrErrorMsg, IConverterApplicationPreferences pcap);
}

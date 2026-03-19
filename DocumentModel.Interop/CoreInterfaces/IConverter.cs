
namespace DocumentModel.Interop.Core;

public interface IConverter
{
  void HrInitConverter
    (IConverterApplicationPreferences pcap, out IConverterPreferences ppcp, IConverterUICallback pcuic);

  void HrUninitConverter(IConverterUICallback pcuic);

  void HrImport
  (string bstrSourcePath, string bstrDestPath, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);

  void HrExport
  (string bstrSourcePath, string bstrDestPath, string bstrClass, IConverterApplicationPreferences pcap,
    out IConverterPreferences ppcp, IConverterUICallback pcuic);

  void HrGetFormat
  (string bstrPath, out string pbstrClass, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);

  void HrGetErrorString(int hrErr, out string pbstrErrorMsg, IConverterApplicationPreferences pcap);
}
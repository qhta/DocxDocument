namespace DocumentModel.Interop.Core;

public enum CertificateVerificationResults
{
  certverresError,
  certverresVerifying,
  certverresUnverified,
  certverresValid,
  certverresInvalid,
  certverresExpired,
  certverresRevoked,
  certverresUntrusted
}
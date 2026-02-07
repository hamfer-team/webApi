namespace Hamfer.WebApi.Core.ContentTypes;

// Data that consists of multiple components which may individually have different MIME types.
// https://www.iana.org/assignments/media-types/media-types.xhtml#multipart
// To use csv: ^([^,]+),(multipart/[a-z0-9+-_]+),(.+)$	=>	\t"$1": "$2",\t\t// '$1' from reference $3
// last updated as 2025-12-25
public static class MultipartContentType
{
	public static readonly Dictionary<string, string> ContentTypes = new()
	{
    {"alternative", "multipart/alternative"},		// 'alternative' from reference [RFC2046][RFC2045]
    {"appledouble", "multipart/appledouble"},		// 'appledouble' from reference [Patrik_Faltstrom]
    {"byteranges", "multipart/byteranges"},		// 'byteranges' from reference [RFC9110]
    {"digest", "multipart/digest"},		// 'digest' from reference [RFC2046][RFC2045]
    {"encrypted", "multipart/encrypted"},		// 'encrypted' from reference [RFC1847]
    {"example", "multipart/example"},		// 'example' from reference [RFC4735]
    {"form-data", "multipart/form-data"},		// 'form-data' from reference [RFC7578]
    {"header-set", "multipart/header-set"},		// 'header-set' from reference [Dave_Crocker]
    {"mixed", "multipart/mixed"},		// 'mixed' from reference [RFC2046][RFC2045]
    {"multilingual", "multipart/multilingual"},		// 'multilingual' from reference [RFC8255]
    {"parallel", "multipart/parallel"},		// 'parallel' from reference [RFC2046][RFC2045]
    {"related", "multipart/related"},		// 'related' from reference [RFC2387]
    {"report", "multipart/report"},		// 'report' from reference [RFC6522]
    {"signed", "multipart/signed"},		// 'signed' from reference [RFC1847]
    {"vnd.bint.med-plus", "multipart/vnd.bint.med-plus"},		// 'vnd.bint.med-plus' from reference [Heinz-Peter_Schütz]
    {"voice-message", "multipart/voice-message"},		// 'voice-message' from reference [RFC3801]
    {"x-mixed-replace", "multipart/x-mixed-replace"},		// 'x-mixed-replace' from reference [W3C][Robin_Berjon]
	};
}
namespace Hamfer.WebApi.Core.ContentTypes;

// A message that encapsulates other messages. This can be used, for instance, to represent an email that includes a forwarded message as part of its data, or to allow sending very large messages in chunks as if it were multiple messages.
// https://www.iana.org/assignments/media-types/media-types.xhtml#message
// To use csv: ^([^,]+),(message/[a-z0-9+-_]+),(.+)$	=>	\t"$1": "$2",\t\t// '$1' from reference $3
// last updated as 2025-12-25
public static class MessageContentType
{
	public static readonly Dictionary<string, string> ContentTypes = new()
	{
		{"bhttp", "message/bhttp"},		// 'bhttp' from reference [RFC9292]
		{"CPIM", "message/CPIM"},		// 'CPIM' from reference [RFC3862]
		{"delivery-status", "message/delivery-status"},		// 'delivery-status' from reference [RFC1894]
		{"disposition-notification", "message/disposition-notification"},		// 'disposition-notification' from reference [RFC8098]
		{"example", "message/example"},		// 'example' from reference [RFC4735]
		{"external-body", "message/external-body"},		// 'external-body' from reference [RFC2045][RFC2046]
		{"feedback-report", "message/feedback-report"},		// 'feedback-report' from reference [RFC5965]
		{"global", "message/global"},		// 'global' from reference [RFC6532]
		{"global-delivery-status", "message/global-delivery-status"},		// 'global-delivery-status' from reference [RFC6533]
		{"global-disposition-notification", "message/global-disposition-notification"},		// 'global-disposition-notification' from reference [RFC6533]
		{"global-headers", "message/global-headers"},		// 'global-headers' from reference [RFC6533]
		{"http", "message/http"},		// 'http' from reference [RFC9112]
		{"imdn+xml", "message/imdn+xml"},		// 'imdn+xml' from reference [RFC5438]
		{"mls", "message/mls"},		// 'mls' from reference [RFC9420]
		{"news (OBSOLETED by [RFC5537])", "message/news"},		// 'news (OBSOLETED by [RFC5537])' from reference [RFC5537][Henry_Spencer]
		{"ohttp-req", "message/ohttp-req"},		// 'ohttp-req' from reference [RFC9458]
		{"ohttp-res", "message/ohttp-res"},		// 'ohttp-res' from reference [RFC9458]
		{"partial", "message/partial"},		// 'partial' from reference [RFC2045][RFC2046]
		{"rfc822", "message/rfc822"},		// 'rfc822' from reference [RFC2045][RFC2046]
		{"s-http (OBSOLETE)", "message/s-http"},		// 's-http (OBSOLETE)' from reference [RFC2660][Status change of HTTP experiments to Historic]
		{"sip", "message/sip"},		// 'sip' from reference [RFC3261]
		{"sipfrag", "message/sipfrag"},		// 'sipfrag' from reference [RFC3420]
		{"tracking-status", "message/tracking-status"},		// 'tracking-status' from reference [RFC3886]
		{"vnd.si.simp (OBSOLETED by request)", "message/vnd.si.simp"},		// 'vnd.si.simp (OBSOLETED by request)' from reference [Nicholas_Parks_Young]
		{"vnd.wfa.wsc", "message/vnd.wfa.wsc"},		// 'vnd.wfa.wsc' from reference [Mick_Conley]
	};
}
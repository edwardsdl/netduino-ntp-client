#Netduino NTP Client
A library for interacting with a network time server

##Download
You can download the latest version of this library on NuGet. To install `netduino-ntp-client`, run the following command from the package manager console:

    PM> Install-Package AngrySquirrel.Netduino.NtpClient

More information about NuGet package is avaliable at https://nuget.org/packages/AngrySquirrel.Netduino.NtpClient/.

##Using the Library
Using the client is easy! If you simply want to set the time on your Netduino, this is all you need:

    var coordinatedUniversalTime = NtpClient.GetDateTime();
    var localTime = coordinatedUniversalTime.AddHours(-4); // Convert from UTC to your local time
    Utility.SetLocalTime(localTime);

If you want more control, you can build your own NTP request and examine the response using the `Send(NtpPacket, string, int)` method.

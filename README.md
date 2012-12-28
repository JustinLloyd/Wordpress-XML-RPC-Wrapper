Wordpress XML-RPC Wrapper
======================

Welcome
=======
Thanks for your interest in WordpressXMLRPCWrapper. This project is now hosted at https://bitbucket.org/JustinLloyd/wordpressxmlrpcwrapper


License
=======
                      DO WHATEVER PUBLIC LICENSE*
   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

  0. You can do whatever you want to with the work.
  1. You cannot stop anybody from doing whatever they want to with the work.
  2. You cannot revoke anybody elses DO WHATEVER PUBLIC LICENSE in the work.

 This program is free software. It comes without any warranty, to
 the extent permitted by applicable law. You can redistribute it
 and/or modify it under the terms of the DO WHATEVER PUBLIC LICENSE
 
 Software originally created by Justin Lloyd @ http://otakunozoku.com/


About
=====
A C# wrapper class around the new Wordpress 3.4 XMLRPC API.
This is a very early version of the wrapper library and has only a single
function available to it at this time.

** This is a very, very early version and not yet ready prime-time. **

    
Pre-requisites
==============
1. .NET 4.0 - but will probably work fine on 2.0 as well if you want to try
2. Automapper - install via Nuget with "install-package automapper"
3. XMLRPC.NET - install via Nuget with "install-package xmlrpcnet"

* Using Wordpress XMLRPC Wrapper
1. Open up the Visual Studio 2010 solution.
2. Use Nuget to install Automapper and XMLRPC.NET.
3. Edit the three constants for Blog XMLRPC url, user name and password in
   program.cs of the WordpressDemoHarness project.
4. Compile and run the WordpressDemoHarness project. It should log in and list
   all of the blogs available in your Wordpress install.

Support
=======
Absolutely none provided.


Software originally created by Justin Lloyd, October 2012
   and distributed via the DO WHATEVER PUBLIC LICENSE*.


* DO WHATEVER PUBLIC LICENSE is based on the idea of the "WTFPL - Do What The
  Fuck You Want To Public License" available at http://sam.zoy.org/wtfpl/. I
  did not use that license as it has an implicit denial of use exploit in it. I
  added two extra clauses to the DO WHATEVER PUBLIC LICENSE that prevents you
  from revoking the license and preventing other people from doing whatever
  they want to with the work.

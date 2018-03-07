# WebApi的host
这是WebApi在IIS和非IIS运行的demo。常见的，大家习惯把webapi当成一个网站，即以iis为宿主。但是其实也可以owin规范来做自宿主。

## 以iis为宿主
通常以iis为宿主，会经过HttpApplication的19个管道事件，我们可以自定义HttpModule来做出拦截，加上自己的处理逻辑（权限认证，写日志）。
但是WebApi本身也有类似的管道处理的逻辑，感兴趣的朋友可以查一下下面三个类：
* HttpServer
* DelegatingHandler
* HttpRouteDispatcher
在webapi中拦截只需自定义DelegatingHandler，即继承DelegatingHandler，然后覆写其SendAsync方法即可（可以在此方法中加上权限认证，写日志）。

## 以owin规范为自宿主
其实和上面逻辑差不多，不走iis就意味着少了上面的HttpApplication的19个管道事件和一些和iis相关的处理逻辑。一般以owin规范为自宿主的程序，实际就是按Microsoft.Owin.Host.HttpListener来处理请求。
实现owin规范的第三方框架不少：
* ServiceStack
* WebApi
* SignalR
* MVC5
* Nancy

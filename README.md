#OcelotDemo

初始化！

示例

项目地址：https://github.com/Canaban0305/OcelotDemo

1、创建三个项目：不配置HTTPS    =>    OcelotGateway、OrderDemo、GoodsDemo   
			![Ocelot-1](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-1.png?raw=true)

2、配置路由：launchSettings.json

　　OcelotGateway => http://localhost:5000

　　OrderDemo => http://localhost:5001

　　GoodsDemo   => http://localhost:5002

![Ocelot-2](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-2.png?raw=true)

3、配置 OcelotGateway 添加包：Ocelot

![Ocelot-3](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-3.png?raw=true)

4、添加Json文件=>网关配置，将Ocelot.json文件属性 -设置为始终复制

![Ocelot-4](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-4.png?raw=true)

5、将配置添加到程序=>Program.cs
![Ocelot-5](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-5.png?raw=true)


6、Startup.cs添加Ocelot功能

添加引用

    using Ocelot.DependencyInjection;
    using Ocelot.Middleware;

![Ocelot-6](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-6.png?raw=true)

7、启动调试

将程序设置为多项目启动

![Ocelot-7](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-7.png?raw=true)

注意：如果是使用dotnet命令启动，需要在每个项目的Program.cs 文件中设置对应的路由地址，因为dotnet默认启动本地HTTP：5000，HTTPS：5000监听

![Ocelot-8](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-8.png?raw=true)

界面：
![Ocelot-9](https://github.com/Canaban0305/Documents/blob/master/Images/Ocelot-9.png?raw=true)


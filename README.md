# Cinema Web Application

## وصف المشروع

Cinema هو مشروع ويب باستخدام **ASP.NET Core MVC** لإدارة الأفلام، المستخدمين، الطلبات، والدفع عبر Stripe.
يشمل:

* عرض قائمة الأفلام.
* إضافة الأفلام إلى السلة.
* الدفع باستخدام Stripe Checkout.
* لوحة تحكم (Dashboard) لعرض الطلبات الأخيرة وعدد الأفلام والمستخدمين.
* إدارة المستخدمين وترقية أي مستخدم إلى Admin.

## المتطلبات

* .NET SDK 7.0 أو أحدث
* SQL Server (LocalDB أو أي نسخة متاحة)
* Visual Studio 2022 / VS Code
* حساب Stripe لاختبار الدفع

## الهيكلية (File Structure)

```
CinemaProject/
│
├─ Controllers/
│   ├─ AccountController.cs
│   ├─ DashboardController.cs
│   ├─ PaymentController.cs
│   ├─ OrderController.cs
│   └─ ...
│
├─ Models/
│   ├─ ApplicationUser.cs
│   ├─ Movie.cs
│   ├─ Order.cs
│   ├─ OrderItem.cs
│   ├─ CartItem.cs
│   └─ ...
│
├─ Views/
│   ├─ Account/
│   │   ├─ Login.cshtml
│   │   └─ Register.cshtml
│   ├─ Dashboard/
│   │   └─ Index.cshtml
│   ├─ Payment/
│   │   ├─ Success.cshtml
│   │   └─ Cancel.cshtml
│   ├─ Order/
│   │   └─ Checkout.cshtml
│   └─ Shared/
│       ├─ _Layout.cshtml
│       └─ _ValidationScriptsPartial.cshtml
│
├─ Data/
│   └─ AppDbContext.cs
│
├─ wwwroot/
│   ├─ css/
│   ├─ js/
│   └─ images/
│
├─ appsettings.json
├─ Program.cs
└─ Startup.cs (إن وجد)
```

## الإعداد

1. **استنساخ المشروع**:

```bash
git clone <your-repo-url>
cd CinemaProject
```

2. **تحديث قاعدة البيانات**:
   تأكد أن `AppDbContext` في `appsettings.json` يحتوي على الاتصال الصحيح:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=CinemaDb;Trusted_Connection=True;"
}
```

3. **إنشاء الجداول**:

```bash
dotnet ef database update
```

4. **Stripe API Key**:
   أضف مفاتيح Stripe في `appsettings.json`:

```json
"Stripe": {
    "PublishableKey": "<your-publishable-key>",
    "SecretKey": "<your-secret-key>"
}
```

5. **تشغيل المشروع**:

```bash
dotnet run
```

ثم افتح المتصفح على `https://localhost:5001` أو حسب الـ URL.

## مميزات المشروع

* **السلة والدفع**: يمكن إضافة أفلام للسلة والدفع عبر Stripe.
* **Dashboard**:

  * عرض عدد الأفلام والمستخدمين والطلبات.
  * عرض أحدث 5 طلبات مع تفاصيل الأفلام والمستخدمين.
  * إدارة المستخدمين وترقيتهم إلى Admin.
* **التأكد من صلاحيات المستخدم**: إذا لم يكن المستخدم مسجّل دخول، يعاد توجيهه لتسجيل الدخول قبل الدفع.

## ملاحظات

* بعد الدفع، يتم إنشاء الطلب (`Order`) و `OrderItems` مرتبطة بالأفلام الصحيحة لتجنب أي مشكلة FK.
* السلة (`CartItems`) يتم تنظيفها بعد الدفع تلقائياً.
* تصميم الواجهة باستخدام Bootstrap 5.

## التراخيص

* هذا المشروع للتعلم والتجربة الشخصية.
* يمكن تعديله واستخدامه حسب الحاجة.

1. Tạo file .db tại thư mục bất kì
2. Copy đường dẫn db để vào appsettings.json [ConnectionStrings:Sqlite]
3. Chạy Migration
#Add Migration to gen Sqlite
add-migration InitDatabase -Context FallbackDbContext
update-database -Context FallbackDbContext

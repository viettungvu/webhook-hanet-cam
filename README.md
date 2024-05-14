### Tạo file database sqlite:
- Vào thư mục bất kì trên máy tính tạo 1 file theo format <tên database>.db
- Copy đường dẫn file này paste vào appsettings.json, tại section ConnnectionStrings:Sqlite
Note: Lưu ý paste vào file appsettings.json ở cả 2 project WebhookCamAi và project svInsertData

### Mirgation cho database sqlite
- Mở Package Manager Console (Ctrl + `), tại mục Default Project chọn project "Infra"
- Chạy lệnh "add-migration InitSqlite -Context SqliteDbContext"
- Chạy tiếp lệnh "update-database -Context SqliteDbContext"
(Bước này là để EF Gen Code Db tạo bảng trong Sqlite)

### Build 2 project và chạy thử
- Chỉnh sửa thông số chạy service tại appsettings.json
- LogFilePath: Đường dẫn file ghi log
- DelayService: Thời gian delay service (tính bằng giây), cứ sau x giây thì service chạy 1 lần
- MaximumError: số lần lỗi tối đa, trong trường hợp service không insert được data vào HRM thì sẽ đánh là lỗi để lần chạy tiếp theo insert lại, nếu lỗi quá 5 lần thì không insert nữa

### Pushlish và cài service
- Click chuột phải vào project svInserData, chọn publish
- Cấu hình thư mục lưu file publish tại "Target Location"
- Click "Publish"
- Tải file install.bat về, thay tên và đường dẫn file thực thi service
sc.exe create "<tên service>" binpath="<Đường dẫn file exe đã publish>"
sc.exe start "<tên service>"
- Lưu file lại và chạy với quyền admin

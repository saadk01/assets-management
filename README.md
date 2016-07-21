/==== About ====/

Originally developed for a course taken in Apr 2016, this is a .NET environment program developed in C# with persistent data storage via Microssoft (R) SQL Server. Microsoft Visual Studio Community edition is used to develop it.

/==== Program Description & Requirements ====/

This is an mdi multi-form application to keep track of assets assigned to each employee.  The company needs to be able to manage assets such as desktop and laptop computers, IP desk phones and cell phones assigned to employees. 

1. The main entities that must be part of the system include Employee, Department, Vendor, Asset, and Category of asset. 
a. Employee data to track include first name(String), last name(String), the department they belong to(Department), date of hire(DateTime), phone number(String), and desk number(String)
b. Department only needs name(String)
c. Vendor needs name(String) and phone number(String)
d. Category requires name(String)  
e. Asset data to capture include name(String), description(String), serial number(String), vendor(Vendor), employee assigned to(Employee), and date assigned(DateTime)
2. The company needs a form to enter departments into the system and edit the department name if required.
3. The company would like a form to add employees to the system and edit information if required.  They should be able to select a department from a combobox on this form.
4. The company needs a form to input asset categories (such as Desktop PC, Laptop, IP Phone, and Cell Phone) and modify if required. 
5. A form is required to enter Vendor information and modify if required.
6. A form is necessary to enter or update asset data. The Vendor supplying the asset is selected from a populated combobox. The employee assigned to and date assigned are not entered in this form.
7. An asset assignment form is needed to select the asset or assets for a selected employee.  Once an employee is selected please display assets already assigned to this employee and their category (only one asset from each category is allowed to be assigned to an employee).  Once assigned, the asset no longer displays an available asset.  Group the display of unassigned assets by their category in separate controls (one for Desktop PC’s, one for Laptops, etc).  The same form can be used to return assets.  This returns the asset to the available pool.
8. Lookup forms are required for each of the main entities.  Use context menus to call the form to add or edit the entity.
9. The asset lookup form should display all properties (including just the vendor name and employee full name) but not the Id. By default, the form displays all assets but it should be able to be filtered using radio buttons to display available assets, assets that are assigned, assets assigned to a selected employee, and assets by selected category.

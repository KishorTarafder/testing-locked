-- Example queries for course management with ADDEDBY information

-- 1. Get all courses with user information who added them
SELECT 
    c.ID,
    c.TITLE,
    c.INSTRUCTOR,
    c.PRICE,
    c.YOUTUBEID,
    c.ADDEDBY,
    u.Username,
    u.Email,
    u.Balance
FROM COURSES c
LEFT JOIN signup_info u ON c.ADDEDBY = u.Username
ORDER BY c.ID DESC;

-- 2. Get courses added by a specific user
SELECT 
    c.ID,
    c.TITLE,
    c.PRICE,
    c.ADDEDBY
FROM COURSES c
WHERE c.ADDEDBY = 'specific_username'
ORDER BY c.ID DESC;

-- 3. Count how many courses each user has added
SELECT 
    c.ADDEDBY,
    COUNT(*) as CoursesAdded,
    u.Username,
    u.Email
FROM COURSES c
LEFT JOIN signup_info u ON c.ADDEDBY = u.Username
WHERE c.ADDEDBY IS NOT NULL
GROUP BY c.ADDEDBY, u.Username, u.Email
ORDER BY CoursesAdded DESC;

-- 4. Get total value of courses added by each user
SELECT 
    c.ADDEDBY,
    COUNT(*) as CoursesAdded,
    SUM(CAST(c.PRICE as DECIMAL)) as TotalValue,
    u.Username
FROM COURSES c
LEFT JOIN signup_info u ON c.ADDEDBY = u.Username
WHERE c.ADDEDBY IS NOT NULL AND c.PRICE IS NOT NULL
GROUP BY c.ADDEDBY, u.Username
ORDER BY TotalValue DESC;

-- 5. Get courses with complete user details
SELECT 
    c.ID,
    c.TITLE,
    c.INSTRUCTOR,
    c.PRICE,
    c.ADDEDBY,
    u.Username as AddedByUsername,
    u.Email as AddedByEmail,
    u.Balance as AddedByBalance
FROM COURSES c
INNER JOIN signup_info u ON c.ADDEDBY = u.Username
WHERE c.ADDEDBY IS NOT NULL
ORDER BY c.ID DESC; 
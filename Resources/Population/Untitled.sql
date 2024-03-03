USE company_catalogue;


INSERT INTO company (name, description, location, website, logo, industry, established, other_details) VALUES 
('ABC Corporation', 'Leading tech company specializing in AI solutions.', 'San Francisco, CA', 'https://www.abccorp.com', 'abccorp_logo.png', 'Technology', '2005-09-15', 'ISO 9001 certified'),
('XYZ Ltd.', 'Global manufacturing conglomerate.', 'Tokyo, Japan', 'https://www.xyzltd.com', 'xyz_logo.png', 'Manufacturing', '1990-03-21', 'Listed on NYSE'),
('Alpha Services', 'Provides consulting services for startups.', 'New York, NY', 'https://www.alphaservices.com', 'alpha_logo.png', 'Consulting', '2010-11-30', '1000+ employees'),
('Beta Solutions', 'Software development company focusing on fintech solutions.', 'London, UK', 'https://www.betasolutions.com', 'beta_logo.png', 'Software', '2008-07-12', 'Award-winning products'),
('Gamma Innovations', 'R&D firm specializing in renewable energy technologies.', 'Berlin, Germany', 'https://www.gamma-innovations.com', 'gamma_logo.png', 'Energy', '2015-05-08', 'Patented technologies'),
('Delta Corporation', 'Diversified conglomerate with interests in real estate, hospitality, and retail.', 'Dubai, UAE', 'https://www.delta-corp.com', 'delta_logo.png', 'Diversified', '2000-12-03', 'Listed on DFM'),
('Omega Enterprises', 'Leading provider of cloud computing solutions.', 'Sydney, Australia', 'https://www.omegaenterprises.com', 'omega_logo.png', 'Technology', '2012-10-17', 'Acquired by Amazon in 2020'),
('Sigma Systems', 'Telecommunications software company.', 'Toronto, Canada', 'https://www.sigmasystems.com', 'sigma_logo.png', 'Telecommunications', '1998-04-26', 'Operates in 50+ countries'),
('NuTech Solutions', 'Provides cybersecurity services for government and enterprise clients.', 'Washington, D.C.', 'https://www.nutechsolutions.com', 'nutech_logo.png', 'Security', '2018-08-02', 'ISO 27001 certified'),
('Epsilon Electronics', 'Consumer electronics manufacturer.', 'Seoul, South Korea', 'https://www.epsilon-electronics.com', 'epsilon_logo.png', 'Electronics', '2003-06-11', 'Award-winning products');

INSERT INTO user (first_name, last_name, email, password_hash, role_id, profile_picture, bio) VALUES 
('John', 'Doe', 'john@example.com', 'hashed_password_123', 1, 'john_profile.jpg', 'Intern at ABC Corporation'),
('Alice', 'Smith', 'alice@example.com', 'hashed_password_456', 2, 'alice_profile.jpg', 'Former employee at XYZ Ltd., now pursuing graduate studies'),
('Bob', 'Johnson', 'bob@example.com', 'hashed_password_789', 3, 'bob_profile.jpg', 'Administrator at Alpha Services'),
('Emily', 'Brown', 'emily@example.com', 'hashed_password_abc', 1, 'emily_profile.jpg', 'Intern at Beta Solutions'),
('Michael', 'Wilson', 'michael@example.com', 'hashed_password_def', 2, 'michael_profile.jpg', 'Former employee at Gamma Innovations, now working as a freelancer'),
('Sophia', 'Lee', 'sophia@example.com', 'hashed_password_ghi', 1, 'sophia_profile.jpg', 'Intern at Delta Corporation'),
('Daniel', 'Garcia', 'daniel@example.com', 'hashed_password_jkl', 2, 'daniel_profile.jpg', 'Former employee at Omega Enterprises, now pursuing MBA'),
('Olivia', 'Martinez', 'olivia@example.com', 'hashed_password_mno', 1, 'olivia_profile.jpg', 'Intern at Sigma Systems'),
('James', 'Rodriguez', 'james@example.com', 'hashed_password_pqr', 3, 'james_profile.jpg', 'Administrator at NuTech Solutions'),
('Emma', 'Hernandez', 'emma@example.com', 'hashed_password_stu', 1, 'emma_profile.jpg', 'Intern at Epsilon Electronics');

INSERT INTO story (company_id, user_id, title, content, posted, likes, status) VALUES 
(1, 1, 'My Internship Experience at ABC Corporation', 'This is a story about my journey as an intern at ABC Corporation.', '2023-07-10 09:00:00', 50, 'published'),
(2, 2, 'Life at XYZ Ltd.', 'Sharing my experiences working at XYZ Ltd. and the lessons learned.', '2023-09-28 15:30:00', 35, 'published'),
(3, 3, 'Admin Insights: Managing Teams at Alpha Services', 'Insights and tips on team management from my experience at Alpha Services.', '2023-11-15 11:45:00', 20, 'published'),
(4, 4, 'Building Innovative Solutions at Beta Solutions', 'Exploring the journey of innovation and product development at Beta Solutions.', '2024-01-05 10:20:00', 15, 'published'),
(5, 5, 'Green Energy Revolution: My Work at Gamma Innovations', 'Discussing the importance of renewable energy and the projects I worked on at Gamma Innovations.', '2024-02-20 14:00:00', 10, 'published'),
(6, 6, 'Exploring Diverse Opportunities at Delta Corporation', 'Diving into the diverse opportunities and challenges I encountered at Delta Corporation.', '2024-03-01 08:45:00', 5, 'pending'),
(7, 7, 'Cloud Computing: The Future with Omega Enterprises', 'Exploring the potential of cloud computing and my role at Omega Enterprises.', '2024-03-02 12:10:00', 8, 'published'),
(8, 8, 'Telecom Solutions for a Connected World by Sigma Systems', 'My experiences working on telecom solutions and the impact on connectivity.', '2024-03-02 16:55:00', 3, 'published'),
(9, 9, 'Securing the Digital World: Insights from NuTech Solutions', 'Insights into cybersecurity challenges and solutions from NuTech Solutions.', '2024-03-02 18:30:00', 7, 'published'),
(10, 10, 'Innovation in Electronics: A Journey with Epsilon Electronics', 'Exploring the innovation journey and product developments in consumer electronics.', '2024-03-03 09:20:00', 2, 'published');

INSERT INTO comment (story_id, user_id, content, date_posted) VALUES 
(1, 2, 'Great story, John! Enjoyed reading about your internship experience.', '2023-07-12 10:15:00'),
(2, 3, 'Alice, your insights are invaluable. Thanks for sharing!', '2023-09-30 14:20:00'),
(3, 4, 'Bob, your tips on team management are spot on!', '2023-11-17 09:30:00'),
(4, 5, 'Michael, Beta Solutions sounds like an exciting place to work!', '2024-01-07 11:45:00'),
(5, 6, 'Sophia, your work in renewable energy is inspiring!', '2024-02-22 16:00:00'),
(6, 7, 'Looking forward to reading more about your experiences, Daniel!', '2024-03-01 09:00:00'),
(7, 8, 'Olivia, your insights into telecom solutions are enlightening!', '2024-03-02 13:00:00'),
(8, 9, 'James, cybersecurity is indeed a crucial aspect of the digital world.', '2024-03-02 17:30:00'),
(9, 10, 'Emma, excited to learn about innovation in electronics!', '2024-03-03 10:00:00'),
(10, 1, 'John, your story is inspiring. Keep up the great work!', '2024-03-03 11:30:00');

INSERT INTO tag (name) VALUES 
('Internship'),
('Experience'),
('Management'),
('Innovation'),
('Technology'),
('Renewable Energy'),
('Cloud Computing'),
('Telecom'),
('Cybersecurity'),
('Electronics');

-- Liên kết các tag với các câu chuyện
INSERT INTO story_tag (story_id, tag_id) VALUES
(1, 1),
(1, 2),
(3, 3),
(4, 4),
(4, 5),
(5, 6),
(7, 5),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

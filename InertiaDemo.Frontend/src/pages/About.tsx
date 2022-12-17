import { Navigation } from '../components/Navigation';

export interface IAboutProps {
  controller: {
    title: string;
  };
}

const About = ({ controller }: IAboutProps) => {
  return (
    <>
      <Navigation />
      <p>{controller.title}</p>
    </>
  );
};

export default About;
